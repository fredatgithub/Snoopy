namespace CodeRepository
{
  using System.Configuration;

  internal class MyUserSettings : ApplicationSettingsBase
  {
    [UserScopedSetting]
    [DefaultSettingValue("LocalFile")]
    public string SourcefileType
    {
      get
      {
        return (string)this["SourcefileType"];
      }

      set
      {
        this["SourcefileType"] = value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("C:\\")]
    public string CheminRepertoireFichier
    {
      get
      {
        return (string)this["CheminRepertoireFichier"];
      }

      set
      {
        this["CheminRepertoireFichier"] = value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("C:\\")]
    public string CheminFichierLocal
    {
      get
      {
        return (string)this["CheminFichierLocal"];
      }

      set
      {
        this["CheminFichierLocal"] = value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("C:\\")]
    public string CheminBDDLocal
    {
      get
      {
        return (string)this["CheminBDDLocal"];
      }

      set
      {
        this["CheminBDDLocal"] = value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("C:\\")]
    public string BackupEmailAddress
    {
      get
      {
        return (string)this["BackupEmailAddress"];
      }

      set
      {
        this["BackupEmailAddress"] = value;
      }
    }
  }
}