Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.CreatingReadingAndSaving
    Public Class SaveToMultiplePDFFiles
        Public Shared Sub Run()
            ' ExStart:SaveToMultiplePDFFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project As New Project(dataDir + "CreateProject1.mpp")
            Dim saveOptions As New PdfSaveOptions()
            saveOptions.SaveToSeparateFiles = True
            saveOptions.Pages = New List(Of Integer)()
            saveOptions.Pages.Add(1)
            saveOptions.Pages.Add(4)
            project.Save(dataDir + "SaveToMultiplePDFFiles_out.pdf", saveOptions)
            ' ExEnd:SaveToMultiplePDFFiles
        End Sub
    End Class
End Namespace