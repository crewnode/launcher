using System;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;

namespace CrewNode.Updater.Utils
{
    public interface ILauncherUpdateable
    {
        string LauncherIdentifier { get; }
        Assembly LauncherAssembly { get; }
        Icon LauncherIcon { get; }
        Uri LauncherJson { get; }
        Form LauncherUpdaterContext { get; }
    }
}
