namespace IndexCardAppUI
{
    partial class LearningCenter
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
            TabControl = new TabControl();
            TabPageSetCreation = new TabPage();

            SetCreationLeftPanel = new Panel();
            SetCreationSetListTitle = new Label();
            SetCreationSetList = new ListBox();
            SetCreationSetListAddButton = new Button();
            SetCreationSetListDeleteButton = new Button();

            SetCreationCenterPanel = new Panel();
            SetCreationAddIndexCardLabel = new Label();
            SetCreationIndexCardTitleLabel = new Label();
            SetCreationIndexCardTitleTextBox = new TextBox();
            SetCreationIndexCardQuestionLabel = new Label();
            SetCreationIndexCardQuestionTextBox = new TextBox();
            SetCreationIndexCardSolutionLabel = new Label();
            SetCreationIndexCardSolutionTextBox = new TextBox();
            SetCreationIndexCardCreationButton = new Button();


        SetCreationRightPanel = new Panel();
            SetCreationIndexCardTitle = new Label();
            SetCreationIndexCardList = new ListBox();
            SetCreationIndexCardAddButton = new Button();
            SetCreationIndexCardDeleteButton = new Button();
            TabPageSetOverview = new TabPage();
            TabControl.SuspendLayout();
            TabPageSetCreation.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabPageSetCreation);
            TabControl.Controls.Add(TabPageSetOverview);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            // 
            // TabPageSetCreation
            // 
            TabPageSetCreation.Controls.Add(SetCreationCenterPanel);
            TabPageSetCreation.Controls.Add(SetCreationRightPanel);
            TabPageSetCreation.Controls.Add(SetCreationLeftPanel);
            TabPageSetCreation.Name = "TabPageSetCreation";
            TabPageSetCreation.Padding = new Padding(10);
            TabPageSetCreation.Text = "Create and Edit Sets";
            TabPageSetCreation.UseVisualStyleBackColor = true;
            //
            // ----------------------------- Left Area ----------------------------------------------
            //
            //
            // SetCreationLeftPanel
            //
            SetCreationLeftPanel.Controls.Add(SetCreationSetListTitle);
            SetCreationLeftPanel.Controls.Add(SetCreationSetList);
            SetCreationLeftPanel.Controls.Add(SetCreationSetListAddButton);
            SetCreationLeftPanel.Controls.Add(SetCreationSetListDeleteButton);
            SetCreationLeftPanel.Name = "SetCreateionLeftPanel";
            SetCreationLeftPanel.Dock = DockStyle.Left;
            SetCreationLeftPanel.Width = ApplicationLayouts.GetFormWidth(0.2);
            //
            // SetCreationSetListTitle
            //
            SetCreationSetListTitle.AutoSize = true;
            SetCreationSetListTitle.Text = "Sets";
            SetCreationSetListTitle.Name = "SetCreationSetListTitle";
            SetCreationSetListTitle.Location = new Point(0, 10);
            // 
            // SetCreationSetList
            // 
            SetCreationSetList.FormattingEnabled = true;
            SetCreationSetList.Name = "SetCreationSetList";
            SetCreationSetList.Size = new Size(ApplicationLayouts.GetFormWidth(0.2), ApplicationLayouts.GetFormHeight(0.7));
            SetCreationSetList.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.1));
            //
            // SetCreationSetListAddButton
            //
            SetCreationSetListAddButton.Name = "SetCreationSetListAddButton";
            SetCreationSetListAddButton.Text = "+";
            SetCreationSetListAddButton.Size = new Size(ApplicationLayouts.GetFormWidth(0.1), ApplicationLayouts.GetFormHeight(0.1));
            SetCreationSetListAddButton.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.8));
            //
            // SetCreationSetListDeleteButton
            //
            SetCreationSetListDeleteButton.Name = "SetCreationSetListDeleteButton";
            SetCreationSetListDeleteButton.Text = "-";
            SetCreationSetListDeleteButton.Size = new Size(ApplicationLayouts.GetFormWidth(0.1), ApplicationLayouts.GetFormHeight(0.1));
            SetCreationSetListDeleteButton.Location = new Point(ApplicationLayouts.GetFormWidth(0.1), ApplicationLayouts.GetFormHeight(0.8));
            //
            // ----------------------------- Center Area ----------------------------------------------
            //
            //
            // SetCreationCenterPanel
            //
            SetCreationCenterPanel.Controls.Add(SetCreationAddIndexCardLabel);
            SetCreationCenterPanel.Controls.Add(SetCreationIndexCardTitleLabel);
            SetCreationCenterPanel.Controls.Add(SetCreationIndexCardTitleTextBox);
            SetCreationCenterPanel.Controls.Add(SetCreationIndexCardQuestionLabel);
            SetCreationCenterPanel.Controls.Add(SetCreationIndexCardQuestionTextBox);
            SetCreationCenterPanel.Controls.Add(SetCreationIndexCardSolutionLabel);
            SetCreationCenterPanel.Controls.Add(SetCreationIndexCardSolutionTextBox);
            SetCreationCenterPanel.Controls.Add(SetCreationIndexCardCreationButton);
            SetCreationCenterPanel.Name = "SetCreationCenterPanel";
            SetCreationCenterPanel.Dock = DockStyle.Fill;
            //
            // SetCreationAddIndexCardLabel
            //
            SetCreationAddIndexCardLabel.AutoSize = true;
            SetCreationAddIndexCardLabel.Text = "Add Index Card";
            SetCreationAddIndexCardLabel.Name = "SetCreationAddIndexCardLabel";
            SetCreationAddIndexCardLabel.Location = new Point(0, 10);
            //
            // SetCreationIndexCardTitleLabel
            //
            SetCreationIndexCardTitleLabel.AutoSize = true;
            SetCreationIndexCardTitleLabel.Text = "Title";
            SetCreationIndexCardTitleLabel.Name = "SetCreationIndexCardTitleLabel";
            SetCreationIndexCardTitleLabel.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.2));
            //
            // SetCreationIndexCardTitleTextBox
            //
            SetCreationIndexCardTitleTextBox.Name = "SetCreationIndexCardTitleTextBox";
            SetCreationIndexCardTitleTextBox.Multiline = true;
            SetCreationIndexCardTitleTextBox.Size = new Size(ApplicationLayouts.GetFormWidth(0.6), ApplicationLayouts.GetFormHeight(0.1));
            SetCreationIndexCardTitleTextBox.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.3));
            //
            // SetCreationIndexCardQuestionLabel
            //
            SetCreationIndexCardQuestionLabel.AutoSize = true;
            SetCreationIndexCardQuestionLabel.Text = "Question";
            SetCreationIndexCardQuestionLabel.Name = "SetCreationIndexCardQuestionLabel";
            SetCreationIndexCardQuestionLabel.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.4));
            //
            // SetCreationIndexCardQuestionTextBox
            //
            SetCreationIndexCardQuestionTextBox.Name = "SetCreationIndexCardQuestionTextBox";
            SetCreationIndexCardQuestionTextBox.Multiline = true;
            SetCreationIndexCardQuestionTextBox.Size = new Size(ApplicationLayouts.GetFormWidth(0.6), ApplicationLayouts.GetFormHeight(0.1));
            SetCreationIndexCardQuestionTextBox.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.5));
            //
            // SetCreationIndexCardSolutionLabel
            //
            SetCreationIndexCardSolutionLabel.AutoSize = true;
            SetCreationIndexCardSolutionLabel.Text = "Solution";
            SetCreationIndexCardSolutionLabel.Name = "SetCreationIndexCardSolutionLabel";
            SetCreationIndexCardSolutionLabel.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.6));
            //
            // SetCreationIndexCardSolutionTextBox
            //
            SetCreationIndexCardSolutionTextBox.Name = "SetCreationIndexCardSolutionTextBox";
            SetCreationIndexCardSolutionTextBox.Multiline = true;
            SetCreationIndexCardSolutionTextBox.Size = new Size(ApplicationLayouts.GetFormWidth(0.6), ApplicationLayouts.GetFormHeight(0.1));
            SetCreationIndexCardSolutionTextBox.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.7));
            //
            // SetCreationIndexCardCreationButton
            //
            SetCreationIndexCardCreationButton.Name = "SetCreationIndexCardCreationButton";
            SetCreationIndexCardCreationButton.Text = "Create Index Card";
            SetCreationIndexCardCreationButton.Size = new Size(ApplicationLayouts.GetFormWidth(0.6), ApplicationLayouts.GetFormHeight(0.1));
            SetCreationIndexCardCreationButton.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.8));
            //
            // ----------------------------- Right Area ----------------------------------------------
            //
            //
            // SetCreationRightPanel
            //
            SetCreationRightPanel.Controls.Add(SetCreationIndexCardTitle);
            SetCreationRightPanel.Controls.Add(SetCreationIndexCardList);
            SetCreationRightPanel.Controls.Add(SetCreationIndexCardAddButton);
            SetCreationRightPanel.Controls.Add(SetCreationIndexCardDeleteButton);
            SetCreationRightPanel.Name = "SetCreationRightPanel";
            SetCreationRightPanel.Dock = DockStyle.Right;
            SetCreationRightPanel.Width = ApplicationLayouts.GetFormWidth(0.2);
            //
            // SetCreationIndexCardTitle
            //
            SetCreationIndexCardTitle.AutoSize = true;
            SetCreationIndexCardTitle.Text = "Index Cards";
            SetCreationIndexCardTitle.Name = "SetCreationIndexCardTitle";
            SetCreationIndexCardTitle.Location = new Point(0, 10);
            // 
            // SetCreationIndexCardList
            // 
            SetCreationIndexCardList.FormattingEnabled = true;
            SetCreationIndexCardList.Name = "SetCreationIndexCardList";
            SetCreationIndexCardList.Size = new Size(ApplicationLayouts.GetFormWidth(0.2), ApplicationLayouts.GetFormHeight(0.7));
            SetCreationIndexCardList.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.1));
            //
            // SetCreationIndexCardAddButton
            //
            SetCreationIndexCardAddButton.Name = "SetCreationIndexCardAddButton";
            SetCreationIndexCardAddButton.Text = "+";
            SetCreationIndexCardAddButton.Size = new Size(ApplicationLayouts.GetFormWidth(0.1), ApplicationLayouts.GetFormHeight(0.1));
            SetCreationIndexCardAddButton.Location = new Point(0, ApplicationLayouts.GetFormHeight(0.8));
            //
            // SetCreationIndexCardDeleteButton
            //
            SetCreationIndexCardDeleteButton.Name = "SetCreationIndexCardDeleteButton";
            SetCreationIndexCardDeleteButton.Text = "-";
            SetCreationIndexCardDeleteButton.Size = new Size(ApplicationLayouts.GetFormWidth(0.1), ApplicationLayouts.GetFormHeight(0.1));
            SetCreationIndexCardDeleteButton.Location = new Point(ApplicationLayouts.GetFormWidth(0.1), ApplicationLayouts.GetFormHeight(0.8));
            // 
            // TabPageSetOverview
            // 
            TabPageSetOverview.Name = "TabPageSetOverview";
            TabPageSetOverview.Padding = new Padding(3);
            TabPageSetOverview.Text = "Overview and Progress";
            TabPageSetOverview.UseVisualStyleBackColor = true;
            // 
            // LearningCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = ApplicationLayouts.GetFormSize();
            Controls.Add(TabControl);
            Name = "LearningCenter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Learning Center";
            TabControl.ResumeLayout(false);
            TabPageSetCreation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabPageSetCreation;
        private TabPage TabPageSetOverview;

        private Panel SetCreationLeftPanel;
        private Label SetCreationSetListTitle;
        private ListBox SetCreationSetList;
        private Button SetCreationSetListAddButton;
        private Button SetCreationSetListDeleteButton;

        private Panel SetCreationCenterPanel;
        private Label SetCreationAddIndexCardLabel;
        private Label SetCreationIndexCardTitleLabel;
        private TextBox SetCreationIndexCardTitleTextBox;
        private Label SetCreationIndexCardQuestionLabel;
        private TextBox SetCreationIndexCardQuestionTextBox;
        private Label SetCreationIndexCardSolutionLabel;
        private TextBox SetCreationIndexCardSolutionTextBox;
        private Button SetCreationIndexCardCreationButton;

        private Panel SetCreationRightPanel;
        private Label SetCreationIndexCardTitle;
        private ListBox SetCreationIndexCardList;
        private Button SetCreationIndexCardAddButton;
        private Button SetCreationIndexCardDeleteButton;
    }
}
