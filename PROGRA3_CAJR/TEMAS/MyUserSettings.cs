using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//AGREGAR
using System.Configuration;
using System.Drawing;
using PROGRA3_CAJR.Idioma;

namespace PROGRA3_CAJR.TEMAS
{
    public class MyUserSettings : ApplicationSettingsBase
    {
        [UserScopedSetting]
        [DefaultSettingValue("214, 228, 170")]
        public Color PanelMenu
        {
            get
            {
                return ((Color)this["PanelMenu"]);
            }

            set
            {
                this["PanelMenu"] = (Color)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("131, 181, 130")]
        public Color PanelTitulo
        {
            get
            {
                return ((Color)this["PanelTitulo"]);
            }

            set
            {
                this["PanelTitulo"] = (Color)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("0")]
        public int Tema
        {
            get
            {
                return ((int)this["Tema"]);
            }

            set
            {
                this["Tema"] = (int)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("115, 0, 104")]
        public Color FButtonSel
        {
            get
            {
                return ((Color)this["FButtonSel"]);
            }

            set
            {
                this["FButtonSel"] = (Color)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("0")]
        public int Idioma
        {
            get
            {
                return ((int)this["Idioma"]);
            }

            set
            {
                this["Idioma"] = (int)value;
            }
        }



    } //CIERRA LA CLASSE 
} //CIERRA EL NAMESPACE
