namespace Puzzle_2013
{
    partial class UsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // usersListView
            // 
            this.usersListView.Location = new System.Drawing.Point(12, 12);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(662, 299);
            this.usersListView.TabIndex = 0;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.View = System.Windows.Forms.View.Details;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 323);
            this.Controls.Add(this.usersListView);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView usersListView;
    }
}