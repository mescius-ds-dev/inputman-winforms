Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms

NotInheritable Class Program
    Private Sub New()
    End Sub
    ''' <summary>
    ''' アプリケーションのメイン エントリ ポイントです。
    ''' </summary>
    <STAThread>
    Friend Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        Application.Run(New MainForm())
    End Sub
End Class
