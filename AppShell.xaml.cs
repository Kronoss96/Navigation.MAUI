﻿using Navigation.Pages.Profile;

namespace Navigation
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("profile/address", typeof(AddressView));
        }
    }
}
