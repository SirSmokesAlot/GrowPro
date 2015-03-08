Public Class Config
    Public Shared ConfigFile As String = My.Application.Info.DirectoryPath + "\res\config.ini"
    Public Shared INI_File As New IniFile(ConfigFile)

    Public Shared REG_VALUE As String = INI_File.GetString("FirstStart", "reg_event", "(not found)")
End Class
