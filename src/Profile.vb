Public Class Profile
    Public Shared ConfigFile As String = My.Application.Info.DirectoryPath + "/res/profile.ini"
    Public Shared INI_File As New IniFile(ConfigFile)

    Public Shared PROFILE_URL As String = INI_File.GetString("Profile", "url", "(not found)")
    Public Shared PROFILE_NAME As String = INI_File.GetString("Profile", "name", "(not found)")
End Class