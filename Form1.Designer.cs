namespace Aruba_802._1x_config
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.remove_checkbox = new MetroFramework.Controls.MetroCheckBox();
            this.apply_checkbox = new MetroFramework.Controls.MetroCheckBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.switchip_textbox = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.switchport_textbox = new System.Windows.Forms.TextBox();
            this.apply_button = new MetroFramework.Controls.MetroButton();
            this.reset_login_button = new MetroFramework.Controls.MetroButton();
            this.reset_switchvalue_button = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.status_label = new MetroFramework.Controls.MetroLabel();
            this.apply_button_accept_timer = new System.Windows.Forms.Timer(this.components);
            this.batch_button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(101, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(152, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 206;
            this.metroLabel1.Text = "Joshua Bergman // 2022";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // remove_checkbox
            // 
            this.remove_checkbox.AutoSize = true;
            this.remove_checkbox.Location = new System.Drawing.Point(181, 162);
            this.remove_checkbox.Name = "remove_checkbox";
            this.remove_checkbox.Size = new System.Drawing.Size(84, 15);
            this.remove_checkbox.Style = MetroFramework.MetroColorStyle.Orange;
            this.remove_checkbox.TabIndex = 105;
            this.remove_checkbox.Text = "Verwijderen";
            this.remove_checkbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.remove_checkbox.UseSelectable = true;
            this.remove_checkbox.UseStyleColors = true;
            this.remove_checkbox.CheckedChanged += new System.EventHandler(this.remove_checkbox_CheckedChanged);
            // 
            // apply_checkbox
            // 
            this.apply_checkbox.AutoSize = true;
            this.apply_checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.apply_checkbox.Location = new System.Drawing.Point(98, 162);
            this.apply_checkbox.Name = "apply_checkbox";
            this.apply_checkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.apply_checkbox.Size = new System.Drawing.Size(77, 15);
            this.apply_checkbox.Style = MetroFramework.MetroColorStyle.Orange;
            this.apply_checkbox.TabIndex = 104;
            this.apply_checkbox.Text = "Toepassen";
            this.apply_checkbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.apply_checkbox.UseSelectable = true;
            this.apply_checkbox.UseStyleColors = true;
            this.apply_checkbox.CheckedChanged += new System.EventHandler(this.apply_checkbox_CheckedChanged);
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(181, 81);
            this.username_textbox.MaxLength = 32;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(150, 23);
            this.username_textbox.TabIndex = 1;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(181, 110);
            this.password_textbox.MaxLength = 32;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(150, 23);
            this.password_textbox.TabIndex = 2;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 200;
            this.metroLabel2.Text = "Gebruikersnaam:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 201;
            this.metroLabel3.Text = "Wachtwoord:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // switchip_textbox
            // 
            this.switchip_textbox.Location = new System.Drawing.Point(181, 192);
            this.switchip_textbox.MaxLength = 16;
            this.switchip_textbox.Name = "switchip_textbox";
            this.switchip_textbox.Size = new System.Drawing.Size(150, 23);
            this.switchip_textbox.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 192);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 202;
            this.metroLabel4.Text = "Switch IP:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 221);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(82, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 203;
            this.metroLabel5.Text = "Switchpoort:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // switchport_textbox
            // 
            this.switchport_textbox.Location = new System.Drawing.Point(181, 221);
            this.switchport_textbox.MaxLength = 8;
            this.switchport_textbox.Name = "switchport_textbox";
            this.switchport_textbox.Size = new System.Drawing.Size(150, 23);
            this.switchport_textbox.TabIndex = 4;
            // 
            // apply_button
            // 
            this.apply_button.Enabled = false;
            this.apply_button.Location = new System.Drawing.Point(25, 250);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(150, 25);
            this.apply_button.Style = MetroFramework.MetroColorStyle.Orange;
            this.apply_button.TabIndex = 101;
            this.apply_button.Text = "Toepassen";
            this.apply_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.apply_button.UseSelectable = true;
            this.apply_button.UseStyleColors = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // reset_login_button
            // 
            this.reset_login_button.Location = new System.Drawing.Point(181, 250);
            this.reset_login_button.Name = "reset_login_button";
            this.reset_login_button.Size = new System.Drawing.Size(150, 25);
            this.reset_login_button.Style = MetroFramework.MetroColorStyle.Orange;
            this.reset_login_button.TabIndex = 102;
            this.reset_login_button.Text = "Reset inloggegevens";
            this.reset_login_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.reset_login_button.UseSelectable = true;
            this.reset_login_button.UseStyleColors = true;
            this.reset_login_button.Click += new System.EventHandler(this.reset_login_button_Click);
            // 
            // reset_switchvalue_button
            // 
            this.reset_switchvalue_button.Location = new System.Drawing.Point(181, 281);
            this.reset_switchvalue_button.Name = "reset_switchvalue_button";
            this.reset_switchvalue_button.Size = new System.Drawing.Size(150, 25);
            this.reset_switchvalue_button.Style = MetroFramework.MetroColorStyle.Orange;
            this.reset_switchvalue_button.TabIndex = 103;
            this.reset_switchvalue_button.Text = "Reset switchgegevens";
            this.reset_switchvalue_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.reset_switchvalue_button.UseSelectable = true;
            this.reset_switchvalue_button.UseStyleColors = true;
            this.reset_switchvalue_button.Click += new System.EventHandler(this.reset_switchvalue_button_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(129, 313);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 204;
            this.metroLabel6.Text = "Status:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseStyleColors = true;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(181, 313);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(69, 19);
            this.status_label.Style = MetroFramework.MetroColorStyle.Orange;
            this.status_label.TabIndex = 205;
            this.status_label.Text = "Niet bezig";
            this.status_label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.status_label.UseStyleColors = true;
            // 
            // apply_button_accept_timer
            // 
            this.apply_button_accept_timer.Tick += new System.EventHandler(this.apply_button_accept_timer_Tick);
            // 
            // batch_button
            // 
            this.batch_button.Enabled = false;
            this.batch_button.Location = new System.Drawing.Point(25, 281);
            this.batch_button.Name = "batch_button";
            this.batch_button.Size = new System.Drawing.Size(150, 25);
            this.batch_button.Style = MetroFramework.MetroColorStyle.Orange;
            this.batch_button.TabIndex = 207;
            this.batch_button.Text = "Batch toepassen";
            this.batch_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.batch_button.UseSelectable = true;
            this.batch_button.UseStyleColors = true;
            this.batch_button.Click += new System.EventHandler(this.batch_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 339);
            this.Controls.Add(this.batch_button);
            this.Controls.Add(this.apply_checkbox);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.remove_checkbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.switchport_textbox);
            this.Controls.Add(this.reset_switchvalue_button);
            this.Controls.Add(this.switchip_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.reset_login_button);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.apply_button);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Aruba 802.1x config manager";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox remove_checkbox;
        private MetroFramework.Controls.MetroCheckBox apply_checkbox;
        private TextBox username_textbox;
        private TextBox password_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private TextBox switchip_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private TextBox switchport_textbox;
        private MetroFramework.Controls.MetroButton apply_button;
        private MetroFramework.Controls.MetroButton reset_login_button;
        private MetroFramework.Controls.MetroButton reset_switchvalue_button;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel status_label;
        private System.Windows.Forms.Timer apply_button_accept_timer;
        private MetroFramework.Controls.MetroButton batch_button;
    }
}