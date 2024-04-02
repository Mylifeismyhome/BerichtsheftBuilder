using BerichtsheftBuilder.Forms;
using BerichtsheftBuilder.service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BerichtsheftBuilder.Form
{
    public class ApplicationController : System.Windows.Forms.Form
    {
        private ProfileService profileService = Program.ServiceProvider.GetService<ProfileService>();

        public delegate void OnPostConstruct(ApplicationController controller);
        private OnPostConstruct postConstruct;
        public OnPostConstruct PostConstruct
        {
            get => postConstruct;
            set => postConstruct = value;
        }

        private System.Windows.Forms.Form form;
        public System.Windows.Forms.Form Form
        {
            get => form;
        }

        public ApplicationController()
        {
            postConstruct = null;
            form = null;
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Opacity = 0;

            base.OnLoad(e);

            if (postConstruct != null)
            {
                postConstruct.Invoke(this);
            }
        }

        public void switchForm(System.Windows.Forms.Form newForm)
        {
            System.Drawing.Point location = Location;

            if (form != null)
            {
                location = form.Location;
            }

            newForm.FormClosed += onFormClosed;
            newForm.Location = location;
            newForm.Show();

            if (form != null)
            {
                form.FormClosed -= onFormClosed;
                form.Dispose();
            }

            form = newForm;
        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
