
namespace Sudoku_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BeginnerLvl = new System.Windows.Forms.RadioButton();
            this.IntermLvl = new System.Windows.Forms.RadioButton();
            this.AdvancedLvl = new System.Windows.Forms.RadioButton();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnNewGame = new XanderUI.XUISuperButton();
            this.btnCheck = new XanderUI.XUISuperButton();
            this.btnClear = new XanderUI.XUISuperButton();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.SeaShell;
            this.MainPanel.Controls.Add(this.btnClear);
            this.MainPanel.Controls.Add(this.btnCheck);
            this.MainPanel.Controls.Add(this.btnNewGame);
            this.MainPanel.Controls.Add(this.lblLevel);
            this.MainPanel.Controls.Add(this.AdvancedLvl);
            this.MainPanel.Controls.Add(this.IntermLvl);
            this.MainPanel.Controls.Add(this.BeginnerLvl);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.MaximumSize = new System.Drawing.Size(800, 1200);
            this.MainPanel.MinimumSize = new System.Drawing.Size(800, 1200);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 1200);
            this.MainPanel.TabIndex = 0;
            // 
            // BeginnerLvl
            // 
            this.BeginnerLvl.AutoSize = true;
            this.BeginnerLvl.ForeColor = System.Drawing.Color.Sienna;
            this.BeginnerLvl.Location = new System.Drawing.Point(589, 297);
            this.BeginnerLvl.Name = "BeginnerLvl";
            this.BeginnerLvl.Size = new System.Drawing.Size(104, 21);
            this.BeginnerLvl.TabIndex = 0;
            this.BeginnerLvl.TabStop = true;
            this.BeginnerLvl.Text = "Начальный";
            this.BeginnerLvl.UseVisualStyleBackColor = true;
            // 
            // IntermLvl
            // 
            this.IntermLvl.AutoSize = true;
            this.IntermLvl.ForeColor = System.Drawing.Color.Sienna;
            this.IntermLvl.Location = new System.Drawing.Point(590, 324);
            this.IntermLvl.Name = "IntermLvl";
            this.IntermLvl.Size = new System.Drawing.Size(86, 21);
            this.IntermLvl.TabIndex = 1;
            this.IntermLvl.TabStop = true;
            this.IntermLvl.Text = "Средний";
            this.IntermLvl.UseVisualStyleBackColor = true;
            // 
            // AdvancedLvl
            // 
            this.AdvancedLvl.AutoSize = true;
            this.AdvancedLvl.ForeColor = System.Drawing.Color.Sienna;
            this.AdvancedLvl.Location = new System.Drawing.Point(589, 351);
            this.AdvancedLvl.Name = "AdvancedLvl";
            this.AdvancedLvl.Size = new System.Drawing.Size(118, 21);
            this.AdvancedLvl.TabIndex = 2;
            this.AdvancedLvl.TabStop = true;
            this.AdvancedLvl.Text = "Продвинутый";
            this.AdvancedLvl.UseVisualStyleBackColor = true;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLevel.ForeColor = System.Drawing.Color.Sienna;
            this.lblLevel.Location = new System.Drawing.Point(581, 249);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(164, 45);
            this.lblLevel.TabIndex = 15;
            this.lblLevel.Text = "Уровень";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackgroundColor = System.Drawing.Color.Sienna;
            this.btnNewGame.ButtonImage = null;
            this.btnNewGame.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnNewGame.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnNewGame.ButtonText = "Новая игра";
            this.btnNewGame.CornerRadius = 8;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewGame.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNewGame.HoverBackgroundColor = System.Drawing.Color.LightSalmon;
            this.btnNewGame.HoverTextColor = System.Drawing.Color.White;
            this.btnNewGame.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnNewGame.Location = new System.Drawing.Point(589, 398);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.SelectedBackColor = System.Drawing.Color.Sienna;
            this.btnNewGame.SelectedTextColor = System.Drawing.Color.White;
            this.btnNewGame.Size = new System.Drawing.Size(130, 67);
            this.btnNewGame.SuperSelected = false;
            this.btnNewGame.TabIndex = 16;
            this.btnNewGame.TextColor = System.Drawing.Color.White;
            this.btnNewGame.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackgroundColor = System.Drawing.Color.Sienna;
            this.btnCheck.ButtonImage = null;
            this.btnCheck.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCheck.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnCheck.ButtonText = "Проверить";
            this.btnCheck.CornerRadius = 8;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheck.HoverBackgroundColor = System.Drawing.Color.LightSalmon;
            this.btnCheck.HoverTextColor = System.Drawing.Color.White;
            this.btnCheck.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnCheck.Location = new System.Drawing.Point(589, 42);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.SelectedBackColor = System.Drawing.Color.Sienna;
            this.btnCheck.SelectedTextColor = System.Drawing.Color.White;
            this.btnCheck.Size = new System.Drawing.Size(130, 67);
            this.btnCheck.SuperSelected = false;
            this.btnCheck.TabIndex = 17;
            this.btnCheck.TextColor = System.Drawing.Color.White;
            this.btnCheck.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundColor = System.Drawing.Color.Sienna;
            this.btnClear.ButtonImage = null;
            this.btnClear.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnClear.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnClear.ButtonText = "Очистить поля";
            this.btnClear.CornerRadius = 8;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClear.HoverBackgroundColor = System.Drawing.Color.LightSalmon;
            this.btnClear.HoverTextColor = System.Drawing.Color.White;
            this.btnClear.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnClear.Location = new System.Drawing.Point(590, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.SelectedBackColor = System.Drawing.Color.Sienna;
            this.btnClear.SelectedTextColor = System.Drawing.Color.White;
            this.btnClear.Size = new System.Drawing.Size(130, 67);
            this.btnClear.SuperSelected = false;
            this.btnClear.TabIndex = 18;
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 657);
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(767, 704);
            this.MinimumSize = new System.Drawing.Size(767, 704);
            this.Name = "MainForm";
            this.Text = "Sudoku Game";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.RadioButton AdvancedLvl;
        private System.Windows.Forms.RadioButton IntermLvl;
        private System.Windows.Forms.RadioButton BeginnerLvl;
        private System.Windows.Forms.Label lblLevel;
        private XanderUI.XUISuperButton btnNewGame;
        private XanderUI.XUISuperButton btnClear;
        private XanderUI.XUISuperButton btnCheck;
    }
}

