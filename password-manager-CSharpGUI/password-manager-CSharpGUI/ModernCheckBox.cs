using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager_CSharpGUI
{
    public partial class ModernCheckBox : UserControl
    {
        Image[] checkIcons = null;

        public ModernCheckBox()
        {
            InitializeComponent();

            string off = "iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAO8SURBVEhL7VVdTBRXFP7u7M7YAsVFiixUELbFqIvgD/60jVGxJj7Yl9ImJO2Dpj71xShpQppYE/XBtCGa1MYaxRYtVFMTYkxorHajpEkTWwgSzNKtyi5alRV1oYvuzrpzPWdmYkORuuNbG76HvfeePfd+955zvjOYwhT+dxD2OAEjIyP5iqJUG4ZRKoTQbHNGkFImaV+E9vV6PJ57tnkcJhAT4RwadtKmDTRmm8bnBF1gjIZTNG6nC1yzrBbGEcdisXoiPJJMpl786cdu/NzZh8jAEHQ9ZXtkhmnTVJT5ivDmSj9q1y3i9RiRbyLy722Xv4lt0tbenmvKV00nsVTewRpPEqUvpKFOmpCnQ5cCkYQL52Maut2F+Ojj9zDfP9sYHR3dWFJScox9XPzD4aV8/kCk2sFd3+DTmVGs9uiY4cmCq2AmoFKKEwl2zQguumi+amDJSykscP2FptO/w+f3iaLi/HV+v/90e3t71HwL3eS7REKv37p5L7bn3cCsLMrPhncgX18JuN2AYQA3BqEcPwpEb5uHO8EAvX53rAT7D2/FUPRWR2Vl5dsurl4K8YEzHb9q0/t+w+q8FOT7myCXvQEoirVT0P2meyAXLoG41EWvf2jZM0SeW2JoVMedrBmoXlhRHAgETlKElWr6L5sLaQ2FF6VlkFWLrR3/RHYO5Nr19sIZavN0XPwlCE3Tsuvq6lYprFP+g6uXC0mW+awXTgL5aoU9cwY+++afd815YWHhPI6lNFfEZU6s1eSQz3KYBLSNUmpOk8mkyqGO8KKcdMcSEANX/vVwcSVkz5whnHThlVkvm/P+/v7rSjqd7uUOw2Jn3eF6BKKHCuhpGItDBM7YC2cI3NewbMVcakb6WGtra69i99JT3GFY7Oarj7dAXDgHPHhgvT6VgrgagvJlE3Wa+9ZJDvDHQze6VC9q31qEUCh0cXh4OGwGnbqWj0J+6XJfOGf/jq/RWHQP5VQM1OuALGrXRIx4nDyd55dJP4/mY9uuDzG7vCBOFb2ls7Pz2JPypVu8q6rqieDlQWXvnhNYbkRNCXA1asIZoW4IM6cc3i63Fw2f1OO1OcWyubl5X0NDwxfkMjBON+Fw+IPc3NwD6Ucy59zZblN3LIGU/sisehN8h2fMNc1NhVRg5pTDKxQZb2lpOUSk1PrQwz7jiBltbW3+qqqqz7xe7yoWu21+LnAhcU4bGxu/pfCeJ9OTT+MEYhtKTU1NBXcYFjvpL8e2ZwTSqR4MBge5ermQyEQahbNv6xSm8B8D8BgHcXtHac4OWgAAAABJRU5ErkJggg==";
            string on = "iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAOuSURBVEhL7VVvaFNXFP+9m+Sl0jR7rg2JcTVt12abKe2qnYhjCKLoh+1TN+iYA7dvg7FNilCQfdnHgjhW0LHRsU5bdROKbChWLVKEiWKrsSVdmW1adTW1rUlqSl/+vLdzXp66koFJvm309/Jy7zs59/3uPef8TrCKVfzvIJljDmKxWLkQolHTtA2SJMmmOS/ouq7SuilaF1QUZcE0r0AOMRH6afiKFr1NY6lhLBK0gQQNZ2j8kjYwkbVmsYI4Go22EuEPqppac6l/CFcGRzA1GUEymTI98oPdbkNVzTq8+VYAO3Y18XOCyD8i8l9Ml2fEJmlP8OaE6PzmNJSXF+DblILTrcFiNZ3yRCZNkXsgMD1kw2K4Ap/tfw8bAz4tHo/vq6ysPMY+Fv7i8FI+zxGpfOhwN7Z8+Ai+pjTWOHUIwR75QaLLIZejzL4W9rI0XP5lKL4Efv42hFf8NdI6b/muQCDwa19f36xxYtrJieXlZOunnxzG5g8iKHNpxosKgVLiwbYNe7G2xAtJEshoKYzPX8HwzG9YuK9j+IQHR77bj8jszNn6+vp3LFy9FOKj589elx+kho2TFopS+UXsqf2CTlpBpNnsCckCV2m1EYGHWhDRuST0JQWNr9d5BwYGTlOERSOv5ULinBaDBvdu2K3/LoAqZZMRjarNKVz7PQRZlktbWlq2C9YpO3D1ciEVA69zoznLBYfd4/Ab7/7r/rxhc7vdr3Hp6MYTRyg7Kxz68zZML6bPkzSoqmrjUE/xQzXpLhYpoIT/gXvxUXOWC03PYGbxD5KXBetfqjBsY2Njd0Umkwlyh2Gxs+6Kwe1IP9Q0N6lchKNDiKkRTN2wYsvWV6kZJRM9PT1BYfbSM9xhWOws/EKxlIqi/04nHiYmDBnpdPFGRmcv4erdk1i4J7A46cKOnU0YHx+/Njc3FzaCTl2rhkJ+a3Qk7Ojo+BFvvB+H4i2m0CSUWB2wCCsRLyGtqURqwY2TL+DgwY/hq3Y9por+fHBw8Fg22wTaxbs2m+1UaHRaHOo4BaVu3pBAUS2TVMk55fDG6aQH2ltR6/fqXV1dX7e1tXWSy+RTYkY4HN7rdDqPZtK64+KFIUN3LIFUkprKE0+u/OfMZdlKheQycsrhlYT+uLu7+3si/Yl+vsk+K4gZvb29gYaGhg6Px7OdxW6aiwIXEue0vb39OIX3Mpme/jXmEJsQzc3NddxhWOykP4dpzwuk02QoFJrm6uVCItOfdBfXFlexiv8IgL8Bnj6EWaqHd3MAAAAASUVORK5CYII=";
            checkIcons = new Image[] { Load64Image(off), Load64Image(on) };

            chkMain.Checked = false;
        }

        public void SetIcons(Image[] _checkIcons)
        {
            checkIcons = _checkIcons;
        }

        public new string Text()
        {
            return lblString.Text;
        }

        public new void Text(string text)
        {
            lblString.Text = text;
        }

        private Image Load64Image(string String64)
        {
            //data:image/gif;base64,
            byte[] bytes = Convert.FromBase64String(String64);

            Image image;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }

        private void chkMain_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMain.Checked)
                chkMain.Image = checkIcons[1];
            else
                chkMain.Image = checkIcons[0];
        }

        public bool CheckState()
        {
            return chkMain.Checked;
        }

        public void CheckState(bool state)
        {
            chkMain.Checked = state;
        }

        public void Check()
        {
            chkMain.Checked = true;
        }

        public void Uncheck()
        {
            chkMain.Checked = false;
        }

        public void changeTooltip(string caption, ToolTip tlt)
        {
            tlt.SetToolTip(chkMain, caption);
            tlt.SetToolTip(lblString, caption);
        }
    }
}
