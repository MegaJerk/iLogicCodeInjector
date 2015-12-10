
Imports System.IO

Public Class InventorProcess

	Private inventorApp As Inventor.Application
	Public m_quitInventor As Boolean = False

	Public Sub StartInventor()
		Try
			' Try to get an active instance of Inventor
			Try
				Debug.Print("StartInventor - Trying to find Inventor application")
                inventorApp = TryCast(System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application"), Inventor.Application)
                'inventorApp = DirectCast(Interaction.GetObject(Nothing, "Inventor.Application"), Inventor.Application)
				Debug.Print(" - Found it")
			Catch ex As Exception
                '    System.Windows.Forms.MessageBox.Show("There was a problem getting an Inventor object.", "Error", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            End Try

			' If not active, create a new Inventor session
            If inventorApp Is Nothing Then
                LaunchInventor()
            End If

            'If (inventorApp IsNot Nothing) Then
            'MessageBox.Show(inventorApp.SoftwareVersion.DisplayName, "Inventor Version")
            'End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("There was a problem starting Inventor.", "Error", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try
	End Sub

	Public Sub StopInventor()
		Debug.Print("StopInventor")
		If m_quitInventor = True Then
			Debug.Print(" - Quitting Inventor")
			inventorApp.Quit()
            '			WaitForInventorToDie()
		End If

		inventorApp = Nothing
	End Sub

	Friend ReadOnly Property Application() As Inventor.Application
		Get
			Return inventorApp
		End Get
	End Property

	''' <summary>
	''' This tries to set the active Inventor project to the specified project file (full path name).
	''' </summary>
	''' <remarks></remarks>
	Sub SetInventorProject(ByVal ipjFileName As String)
		Dim currentProjectFile As String = inventorApp.FileLocations.FileLocationsFile
		Debug.Print("Current active project file is: " & currentProjectFile)

		Dim ipjFilePath As New FileInfo(ipjFileName)

		If (String.Equals(currentProjectFile, ipjFilePath.FullName, StringComparison.OrdinalIgnoreCase)) Then
			Return
		End If

		Debug.Print("Checking for project file: " & ipjFilePath.FullName)
		If ipjFilePath.Exists Then
			Try
				inventorApp.FileLocations.FileLocationsFile = ipjFilePath.FullName
				Debug.Print("Set active project file to: " & inventorApp.FileLocations.FileLocationsFile)
			Catch ex As Exception
				Debug.Print("*** Failed to set active project file: " & ex.ToString)
			End Try
		End If

	End Sub


	Sub LaunchInventor()

		Debug.Print("InventorInfo - Launching Inventor...")
		Dim inventorAppType As Type = System.Type.GetTypeFromProgID("Inventor.Application")
		inventorApp = System.Activator.CreateInstance(inventorAppType)
		'm_inventorAppEvents = inventorApp.ApplicationEvents

		WaitForInventorToBeReady()

		inventorApp.Visible = True
		m_quitInventor = True

	End Sub

	Sub WaitForInventorToBeReady()
		Dim inventorReady As Boolean = False
		While Not inventorReady
			System.Threading.Thread.Sleep(100)
			System.Windows.Forms.Application.DoEvents()
			If inventorApp.Ready Then inventorReady = True
		End While
		Debug.Print("InventorInfo - Inventor Ready")
	End Sub

	Sub WaitForInventorToDie()
		' Wait for Inventor to be gone
		Do While Not inventorApp Is Nothing
			Try
				inventorApp = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application")
				System.Threading.Thread.Sleep(100)
			Catch ex As Exception
				Debug.Print(" - Inventor is dead")
				inventorApp = Nothing
			End Try
		Loop
	End Sub


End Class
