using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kolmagorov
{
    partial class Kolmagorov_Battleships
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

        /// <summary>
        /// ///////////////////// ДО ЭТОГО ШЕЛ СГЕНЕРИРОВАННЫЙ КОД
        /// </summary>
        public static Label LabelWin; // эти две ссылки делаются для возможности доступа к ним из других классов
        // можно было бы, конечно не копировать, а сразу делать статичские поля, но winforms мне не дает
        public static TableLayoutPanel linkOnField;

        public void SetLabel()
        {
            LabelWin = label1;
        }

        public void SetlinkOnField()
        {
            linkOnField = tableLayoutPanel2;
        }

        /////////////////////////////////// ОПЯТЬ ПОШЕЛ СГЕНЕРИРОВАННЫЙ КОД
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 
        //к сожалению, эту дурацкую структуру не поменять
        // не советую раскрывать, 2к кода, сгенерированного системой
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kolmagorov_Battleships));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.myButton49 = new Kolmagorov.MyButton();
            this.myButton48 = new Kolmagorov.MyButton();
            this.myButton47 = new Kolmagorov.MyButton();
            this.myButton46 = new Kolmagorov.MyButton();
            this.myButton45 = new Kolmagorov.MyButton();
            this.myButton44 = new Kolmagorov.MyButton();
            this.myButton43 = new Kolmagorov.MyButton();
            this.myButton42 = new Kolmagorov.MyButton();
            this.myButton41 = new Kolmagorov.MyButton();
            this.myButton40 = new Kolmagorov.MyButton();
            this.myButton39 = new Kolmagorov.MyButton();
            this.myButton38 = new Kolmagorov.MyButton();
            this.myButton37 = new Kolmagorov.MyButton();
            this.myButton36 = new Kolmagorov.MyButton();
            this.myButton35 = new Kolmagorov.MyButton();
            this.myButton34 = new Kolmagorov.MyButton();
            this.myButton33 = new Kolmagorov.MyButton();
            this.myButton32 = new Kolmagorov.MyButton();
            this.myButton31 = new Kolmagorov.MyButton();
            this.myButton30 = new Kolmagorov.MyButton();
            this.myButton29 = new Kolmagorov.MyButton();
            this.myButton28 = new Kolmagorov.MyButton();
            this.myButton27 = new Kolmagorov.MyButton();
            this.myButton26 = new Kolmagorov.MyButton();
            this.myButton25 = new Kolmagorov.MyButton();
            this.myButton24 = new Kolmagorov.MyButton();
            this.myButton23 = new Kolmagorov.MyButton();
            this.myButton22 = new Kolmagorov.MyButton();
            this.myButton21 = new Kolmagorov.MyButton();
            this.myButton20 = new Kolmagorov.MyButton();
            this.myButton19 = new Kolmagorov.MyButton();
            this.myButton18 = new Kolmagorov.MyButton();
            this.myButton17 = new Kolmagorov.MyButton();
            this.myButton16 = new Kolmagorov.MyButton();
            this.myButton15 = new Kolmagorov.MyButton();
            this.myButton14 = new Kolmagorov.MyButton();
            this.myButton13 = new Kolmagorov.MyButton();
            this.myButton12 = new Kolmagorov.MyButton();
            this.myButton11 = new Kolmagorov.MyButton();
            this.myButton10 = new Kolmagorov.MyButton();
            this.myButton9 = new Kolmagorov.MyButton();
            this.myButton8 = new Kolmagorov.MyButton();
            this.myButton7 = new Kolmagorov.MyButton();
            this.myButton6 = new Kolmagorov.MyButton();
            this.myButton5 = new Kolmagorov.MyButton();
            this.myButton4 = new Kolmagorov.MyButton();
            this.myButton3 = new Kolmagorov.MyButton();
            this.myButton2 = new Kolmagorov.MyButton();
            this.myButton1 = new Kolmagorov.MyButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.myButton50 = new Kolmagorov.MyButton();
            this.myButton51 = new Kolmagorov.MyButton();
            this.myButton52 = new Kolmagorov.MyButton();
            this.myButton53 = new Kolmagorov.MyButton();
            this.myButton54 = new Kolmagorov.MyButton();
            this.myButton55 = new Kolmagorov.MyButton();
            this.myButton56 = new Kolmagorov.MyButton();
            this.myButton57 = new Kolmagorov.MyButton();
            this.myButton58 = new Kolmagorov.MyButton();
            this.myButton59 = new Kolmagorov.MyButton();
            this.myButton60 = new Kolmagorov.MyButton();
            this.myButton61 = new Kolmagorov.MyButton();
            this.myButton62 = new Kolmagorov.MyButton();
            this.myButton63 = new Kolmagorov.MyButton();
            this.myButton64 = new Kolmagorov.MyButton();
            this.myButton65 = new Kolmagorov.MyButton();
            this.myButton66 = new Kolmagorov.MyButton();
            this.myButton67 = new Kolmagorov.MyButton();
            this.myButton68 = new Kolmagorov.MyButton();
            this.myButton69 = new Kolmagorov.MyButton();
            this.myButton70 = new Kolmagorov.MyButton();
            this.myButton71 = new Kolmagorov.MyButton();
            this.myButton72 = new Kolmagorov.MyButton();
            this.myButton73 = new Kolmagorov.MyButton();
            this.myButton74 = new Kolmagorov.MyButton();
            this.myButton75 = new Kolmagorov.MyButton();
            this.myButton76 = new Kolmagorov.MyButton();
            this.myButton77 = new Kolmagorov.MyButton();
            this.myButton78 = new Kolmagorov.MyButton();
            this.myButton79 = new Kolmagorov.MyButton();
            this.myButton80 = new Kolmagorov.MyButton();
            this.myButton81 = new Kolmagorov.MyButton();
            this.myButton82 = new Kolmagorov.MyButton();
            this.myButton83 = new Kolmagorov.MyButton();
            this.myButton84 = new Kolmagorov.MyButton();
            this.myButton85 = new Kolmagorov.MyButton();
            this.myButton86 = new Kolmagorov.MyButton();
            this.myButton87 = new Kolmagorov.MyButton();
            this.myButton88 = new Kolmagorov.MyButton();
            this.myButton89 = new Kolmagorov.MyButton();
            this.myButton90 = new Kolmagorov.MyButton();
            this.myButton91 = new Kolmagorov.MyButton();
            this.myButton92 = new Kolmagorov.MyButton();
            this.myButton93 = new Kolmagorov.MyButton();
            this.myButton94 = new Kolmagorov.MyButton();
            this.myButton95 = new Kolmagorov.MyButton();
            this.myButton96 = new Kolmagorov.MyButton();
            this.myButton97 = new Kolmagorov.MyButton();
            this.myButton98 = new Kolmagorov.MyButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.myButton49, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.myButton48, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.myButton47, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.myButton46, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.myButton45, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.myButton44, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.myButton43, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.myButton42, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.myButton41, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.myButton40, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.myButton39, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.myButton38, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.myButton37, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.myButton36, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.myButton35, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.myButton34, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.myButton33, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.myButton32, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.myButton31, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.myButton30, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.myButton29, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.myButton28, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButton27, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButton26, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButton25, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButton24, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButton23, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButton22, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.myButton21, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButton20, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButton19, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButton18, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButton17, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButton16, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButton15, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.myButton14, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButton13, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButton12, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButton11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButton10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButton9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButton8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.myButton7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButton6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButton5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButton4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButton3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButton1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 328);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // myButton49
            // 
            this.myButton49.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton49.AutoSize = true;
            this.myButton49.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton49.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton49.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton49.Location = new System.Drawing.Point(294, 276);
            this.myButton49.Margin = new System.Windows.Forms.Padding(0);
            this.myButton49.Name = "myButton49";
            this.myButton49.Size = new System.Drawing.Size(55, 52);
            this.myButton49.TabIndex = 48;
            this.myButton49.UseVisualStyleBackColor = false;
            // 
            // myButton48
            // 
            this.myButton48.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton48.AutoSize = true;
            this.myButton48.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton48.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton48.Location = new System.Drawing.Point(245, 276);
            this.myButton48.Margin = new System.Windows.Forms.Padding(0);
            this.myButton48.Name = "myButton48";
            this.myButton48.Size = new System.Drawing.Size(49, 52);
            this.myButton48.TabIndex = 47;
            this.myButton48.UseVisualStyleBackColor = false;
            // 
            // myButton47
            // 
            this.myButton47.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton47.AutoSize = true;
            this.myButton47.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton47.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton47.Location = new System.Drawing.Point(196, 276);
            this.myButton47.Margin = new System.Windows.Forms.Padding(0);
            this.myButton47.Name = "myButton47";
            this.myButton47.Size = new System.Drawing.Size(49, 52);
            this.myButton47.TabIndex = 46;
            this.myButton47.UseVisualStyleBackColor = false;
            // 
            // myButton46
            // 
            this.myButton46.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton46.AutoSize = true;
            this.myButton46.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton46.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton46.Location = new System.Drawing.Point(147, 276);
            this.myButton46.Margin = new System.Windows.Forms.Padding(0);
            this.myButton46.Name = "myButton46";
            this.myButton46.Size = new System.Drawing.Size(49, 52);
            this.myButton46.TabIndex = 45;
            this.myButton46.UseVisualStyleBackColor = false;
            // 
            // myButton45
            // 
            this.myButton45.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton45.AutoSize = true;
            this.myButton45.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton45.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton45.Location = new System.Drawing.Point(98, 276);
            this.myButton45.Margin = new System.Windows.Forms.Padding(0);
            this.myButton45.Name = "myButton45";
            this.myButton45.Size = new System.Drawing.Size(49, 52);
            this.myButton45.TabIndex = 44;
            this.myButton45.UseVisualStyleBackColor = false;
            // 
            // myButton44
            // 
            this.myButton44.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton44.AutoSize = true;
            this.myButton44.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton44.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton44.Location = new System.Drawing.Point(49, 276);
            this.myButton44.Margin = new System.Windows.Forms.Padding(0);
            this.myButton44.Name = "myButton44";
            this.myButton44.Size = new System.Drawing.Size(49, 52);
            this.myButton44.TabIndex = 43;
            this.myButton44.UseVisualStyleBackColor = false;
            // 
            // myButton43
            // 
            this.myButton43.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton43.AutoSize = true;
            this.myButton43.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton43.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton43.Location = new System.Drawing.Point(0, 276);
            this.myButton43.Margin = new System.Windows.Forms.Padding(0);
            this.myButton43.Name = "myButton43";
            this.myButton43.Size = new System.Drawing.Size(49, 52);
            this.myButton43.TabIndex = 42;
            this.myButton43.UseVisualStyleBackColor = false;
            // 
            // myButton42
            // 
            this.myButton42.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton42.AutoSize = true;
            this.myButton42.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton42.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton42.Location = new System.Drawing.Point(294, 230);
            this.myButton42.Margin = new System.Windows.Forms.Padding(0);
            this.myButton42.Name = "myButton42";
            this.myButton42.Size = new System.Drawing.Size(55, 46);
            this.myButton42.TabIndex = 41;
            this.myButton42.UseVisualStyleBackColor = false;
            // 
            // myButton41
            // 
            this.myButton41.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton41.AutoSize = true;
            this.myButton41.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton41.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton41.Location = new System.Drawing.Point(245, 230);
            this.myButton41.Margin = new System.Windows.Forms.Padding(0);
            this.myButton41.Name = "myButton41";
            this.myButton41.Size = new System.Drawing.Size(49, 46);
            this.myButton41.TabIndex = 40;
            this.myButton41.UseVisualStyleBackColor = false;
            // 
            // myButton40
            // 
            this.myButton40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton40.AutoSize = true;
            this.myButton40.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton40.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton40.Location = new System.Drawing.Point(196, 230);
            this.myButton40.Margin = new System.Windows.Forms.Padding(0);
            this.myButton40.Name = "myButton40";
            this.myButton40.Size = new System.Drawing.Size(49, 46);
            this.myButton40.TabIndex = 39;
            this.myButton40.UseVisualStyleBackColor = false;
            // 
            // myButton39
            // 
            this.myButton39.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton39.AutoSize = true;
            this.myButton39.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton39.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton39.Location = new System.Drawing.Point(147, 230);
            this.myButton39.Margin = new System.Windows.Forms.Padding(0);
            this.myButton39.Name = "myButton39";
            this.myButton39.Size = new System.Drawing.Size(49, 46);
            this.myButton39.TabIndex = 38;
            this.myButton39.UseVisualStyleBackColor = false;
            // 
            // myButton38
            // 
            this.myButton38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton38.AutoSize = true;
            this.myButton38.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton38.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton38.Location = new System.Drawing.Point(98, 230);
            this.myButton38.Margin = new System.Windows.Forms.Padding(0);
            this.myButton38.Name = "myButton38";
            this.myButton38.Size = new System.Drawing.Size(49, 46);
            this.myButton38.TabIndex = 37;
            this.myButton38.UseVisualStyleBackColor = false;
            // 
            // myButton37
            // 
            this.myButton37.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton37.AutoSize = true;
            this.myButton37.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton37.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton37.Location = new System.Drawing.Point(49, 230);
            this.myButton37.Margin = new System.Windows.Forms.Padding(0);
            this.myButton37.Name = "myButton37";
            this.myButton37.Size = new System.Drawing.Size(49, 46);
            this.myButton37.TabIndex = 36;
            this.myButton37.UseVisualStyleBackColor = false;
            // 
            // myButton36
            // 
            this.myButton36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton36.AutoSize = true;
            this.myButton36.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton36.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton36.Location = new System.Drawing.Point(0, 230);
            this.myButton36.Margin = new System.Windows.Forms.Padding(0);
            this.myButton36.Name = "myButton36";
            this.myButton36.Size = new System.Drawing.Size(49, 46);
            this.myButton36.TabIndex = 35;
            this.myButton36.UseVisualStyleBackColor = false;
            // 
            // myButton35
            // 
            this.myButton35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton35.AutoSize = true;
            this.myButton35.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton35.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton35.Location = new System.Drawing.Point(294, 184);
            this.myButton35.Margin = new System.Windows.Forms.Padding(0);
            this.myButton35.Name = "myButton35";
            this.myButton35.Size = new System.Drawing.Size(55, 46);
            this.myButton35.TabIndex = 34;
            this.myButton35.UseVisualStyleBackColor = false;
            // 
            // myButton34
            // 
            this.myButton34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton34.AutoSize = true;
            this.myButton34.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton34.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton34.Location = new System.Drawing.Point(245, 184);
            this.myButton34.Margin = new System.Windows.Forms.Padding(0);
            this.myButton34.Name = "myButton34";
            this.myButton34.Size = new System.Drawing.Size(49, 46);
            this.myButton34.TabIndex = 33;
            this.myButton34.UseVisualStyleBackColor = false;
            // 
            // myButton33
            // 
            this.myButton33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton33.AutoSize = true;
            this.myButton33.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton33.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton33.Location = new System.Drawing.Point(196, 184);
            this.myButton33.Margin = new System.Windows.Forms.Padding(0);
            this.myButton33.Name = "myButton33";
            this.myButton33.Size = new System.Drawing.Size(49, 46);
            this.myButton33.TabIndex = 32;
            this.myButton33.UseVisualStyleBackColor = false;
            // 
            // myButton32
            // 
            this.myButton32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton32.AutoSize = true;
            this.myButton32.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton32.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton32.Location = new System.Drawing.Point(147, 184);
            this.myButton32.Margin = new System.Windows.Forms.Padding(0);
            this.myButton32.Name = "myButton32";
            this.myButton32.Size = new System.Drawing.Size(49, 46);
            this.myButton32.TabIndex = 31;
            this.myButton32.UseVisualStyleBackColor = false;
            // 
            // myButton31
            // 
            this.myButton31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton31.AutoSize = true;
            this.myButton31.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton31.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton31.Location = new System.Drawing.Point(98, 184);
            this.myButton31.Margin = new System.Windows.Forms.Padding(0);
            this.myButton31.Name = "myButton31";
            this.myButton31.Size = new System.Drawing.Size(49, 46);
            this.myButton31.TabIndex = 30;
            this.myButton31.UseVisualStyleBackColor = false;
            // 
            // myButton30
            // 
            this.myButton30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton30.AutoSize = true;
            this.myButton30.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton30.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton30.Location = new System.Drawing.Point(49, 184);
            this.myButton30.Margin = new System.Windows.Forms.Padding(0);
            this.myButton30.Name = "myButton30";
            this.myButton30.Size = new System.Drawing.Size(49, 46);
            this.myButton30.TabIndex = 29;
            this.myButton30.UseVisualStyleBackColor = false;
            // 
            // myButton29
            // 
            this.myButton29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton29.AutoSize = true;
            this.myButton29.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton29.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton29.Location = new System.Drawing.Point(0, 184);
            this.myButton29.Margin = new System.Windows.Forms.Padding(0);
            this.myButton29.Name = "myButton29";
            this.myButton29.Size = new System.Drawing.Size(49, 46);
            this.myButton29.TabIndex = 28;
            this.myButton29.UseVisualStyleBackColor = false;
            // 
            // myButton28
            // 
            this.myButton28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton28.AutoSize = true;
            this.myButton28.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton28.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton28.Location = new System.Drawing.Point(294, 138);
            this.myButton28.Margin = new System.Windows.Forms.Padding(0);
            this.myButton28.Name = "myButton28";
            this.myButton28.Size = new System.Drawing.Size(55, 46);
            this.myButton28.TabIndex = 27;
            this.myButton28.UseVisualStyleBackColor = false;
            // 
            // myButton27
            // 
            this.myButton27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton27.AutoSize = true;
            this.myButton27.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton27.Location = new System.Drawing.Point(245, 138);
            this.myButton27.Margin = new System.Windows.Forms.Padding(0);
            this.myButton27.Name = "myButton27";
            this.myButton27.Size = new System.Drawing.Size(49, 46);
            this.myButton27.TabIndex = 26;
            this.myButton27.UseVisualStyleBackColor = false;
            // 
            // myButton26
            // 
            this.myButton26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton26.AutoSize = true;
            this.myButton26.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton26.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton26.Location = new System.Drawing.Point(196, 138);
            this.myButton26.Margin = new System.Windows.Forms.Padding(0);
            this.myButton26.Name = "myButton26";
            this.myButton26.Size = new System.Drawing.Size(49, 46);
            this.myButton26.TabIndex = 25;
            this.myButton26.UseVisualStyleBackColor = false;
            // 
            // myButton25
            // 
            this.myButton25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton25.AutoSize = true;
            this.myButton25.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton25.Location = new System.Drawing.Point(147, 138);
            this.myButton25.Margin = new System.Windows.Forms.Padding(0);
            this.myButton25.Name = "myButton25";
            this.myButton25.Size = new System.Drawing.Size(49, 46);
            this.myButton25.TabIndex = 24;
            this.myButton25.UseVisualStyleBackColor = false;
            // 
            // myButton24
            // 
            this.myButton24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton24.AutoSize = true;
            this.myButton24.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton24.Location = new System.Drawing.Point(98, 138);
            this.myButton24.Margin = new System.Windows.Forms.Padding(0);
            this.myButton24.Name = "myButton24";
            this.myButton24.Size = new System.Drawing.Size(49, 46);
            this.myButton24.TabIndex = 23;
            this.myButton24.UseVisualStyleBackColor = false;
            // 
            // myButton23
            // 
            this.myButton23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton23.AutoSize = true;
            this.myButton23.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton23.Location = new System.Drawing.Point(49, 138);
            this.myButton23.Margin = new System.Windows.Forms.Padding(0);
            this.myButton23.Name = "myButton23";
            this.myButton23.Size = new System.Drawing.Size(49, 46);
            this.myButton23.TabIndex = 22;
            this.myButton23.UseVisualStyleBackColor = false;
            // 
            // myButton22
            // 
            this.myButton22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton22.AutoSize = true;
            this.myButton22.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton22.Location = new System.Drawing.Point(0, 138);
            this.myButton22.Margin = new System.Windows.Forms.Padding(0);
            this.myButton22.Name = "myButton22";
            this.myButton22.Size = new System.Drawing.Size(49, 46);
            this.myButton22.TabIndex = 21;
            this.myButton22.UseVisualStyleBackColor = false;
            // 
            // myButton21
            // 
            this.myButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton21.AutoSize = true;
            this.myButton21.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton21.Location = new System.Drawing.Point(294, 92);
            this.myButton21.Margin = new System.Windows.Forms.Padding(0);
            this.myButton21.Name = "myButton21";
            this.myButton21.Size = new System.Drawing.Size(55, 46);
            this.myButton21.TabIndex = 20;
            this.myButton21.UseVisualStyleBackColor = false;
            // 
            // myButton20
            // 
            this.myButton20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton20.AutoSize = true;
            this.myButton20.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton20.Location = new System.Drawing.Point(245, 92);
            this.myButton20.Margin = new System.Windows.Forms.Padding(0);
            this.myButton20.Name = "myButton20";
            this.myButton20.Size = new System.Drawing.Size(49, 46);
            this.myButton20.TabIndex = 19;
            this.myButton20.UseVisualStyleBackColor = false;
            // 
            // myButton19
            // 
            this.myButton19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton19.AutoSize = true;
            this.myButton19.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton19.Location = new System.Drawing.Point(196, 92);
            this.myButton19.Margin = new System.Windows.Forms.Padding(0);
            this.myButton19.Name = "myButton19";
            this.myButton19.Size = new System.Drawing.Size(49, 46);
            this.myButton19.TabIndex = 18;
            this.myButton19.UseVisualStyleBackColor = false;
            // 
            // myButton18
            // 
            this.myButton18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton18.AutoSize = true;
            this.myButton18.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton18.Location = new System.Drawing.Point(147, 92);
            this.myButton18.Margin = new System.Windows.Forms.Padding(0);
            this.myButton18.Name = "myButton18";
            this.myButton18.Size = new System.Drawing.Size(49, 46);
            this.myButton18.TabIndex = 17;
            this.myButton18.UseVisualStyleBackColor = false;
            // 
            // myButton17
            // 
            this.myButton17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton17.AutoSize = true;
            this.myButton17.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton17.Location = new System.Drawing.Point(98, 92);
            this.myButton17.Margin = new System.Windows.Forms.Padding(0);
            this.myButton17.Name = "myButton17";
            this.myButton17.Size = new System.Drawing.Size(49, 46);
            this.myButton17.TabIndex = 16;
            this.myButton17.UseVisualStyleBackColor = false;
            // 
            // myButton16
            // 
            this.myButton16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton16.AutoSize = true;
            this.myButton16.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton16.Location = new System.Drawing.Point(49, 92);
            this.myButton16.Margin = new System.Windows.Forms.Padding(0);
            this.myButton16.Name = "myButton16";
            this.myButton16.Size = new System.Drawing.Size(49, 46);
            this.myButton16.TabIndex = 15;
            this.myButton16.UseVisualStyleBackColor = false;
            // 
            // myButton15
            // 
            this.myButton15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton15.AutoSize = true;
            this.myButton15.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton15.Location = new System.Drawing.Point(0, 92);
            this.myButton15.Margin = new System.Windows.Forms.Padding(0);
            this.myButton15.Name = "myButton15";
            this.myButton15.Size = new System.Drawing.Size(49, 46);
            this.myButton15.TabIndex = 14;
            this.myButton15.UseVisualStyleBackColor = false;
            // 
            // myButton14
            // 
            this.myButton14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton14.AutoSize = true;
            this.myButton14.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton14.Location = new System.Drawing.Point(294, 46);
            this.myButton14.Margin = new System.Windows.Forms.Padding(0);
            this.myButton14.Name = "myButton14";
            this.myButton14.Size = new System.Drawing.Size(55, 46);
            this.myButton14.TabIndex = 13;
            this.myButton14.UseVisualStyleBackColor = false;
            // 
            // myButton13
            // 
            this.myButton13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton13.AutoSize = true;
            this.myButton13.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton13.Location = new System.Drawing.Point(245, 46);
            this.myButton13.Margin = new System.Windows.Forms.Padding(0);
            this.myButton13.Name = "myButton13";
            this.myButton13.Size = new System.Drawing.Size(49, 46);
            this.myButton13.TabIndex = 12;
            this.myButton13.UseVisualStyleBackColor = false;
            // 
            // myButton12
            // 
            this.myButton12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton12.AutoSize = true;
            this.myButton12.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton12.Location = new System.Drawing.Point(196, 46);
            this.myButton12.Margin = new System.Windows.Forms.Padding(0);
            this.myButton12.Name = "myButton12";
            this.myButton12.Size = new System.Drawing.Size(49, 46);
            this.myButton12.TabIndex = 11;
            this.myButton12.UseVisualStyleBackColor = false;
            // 
            // myButton11
            // 
            this.myButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton11.AutoSize = true;
            this.myButton11.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton11.Location = new System.Drawing.Point(147, 46);
            this.myButton11.Margin = new System.Windows.Forms.Padding(0);
            this.myButton11.Name = "myButton11";
            this.myButton11.Size = new System.Drawing.Size(49, 46);
            this.myButton11.TabIndex = 10;
            this.myButton11.UseVisualStyleBackColor = false;
            // 
            // myButton10
            // 
            this.myButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton10.AutoSize = true;
            this.myButton10.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton10.Location = new System.Drawing.Point(98, 46);
            this.myButton10.Margin = new System.Windows.Forms.Padding(0);
            this.myButton10.Name = "myButton10";
            this.myButton10.Size = new System.Drawing.Size(49, 46);
            this.myButton10.TabIndex = 9;
            this.myButton10.UseVisualStyleBackColor = false;
            // 
            // myButton9
            // 
            this.myButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton9.AutoSize = true;
            this.myButton9.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton9.Location = new System.Drawing.Point(49, 46);
            this.myButton9.Margin = new System.Windows.Forms.Padding(0);
            this.myButton9.Name = "myButton9";
            this.myButton9.Size = new System.Drawing.Size(49, 46);
            this.myButton9.TabIndex = 8;
            this.myButton9.UseVisualStyleBackColor = false;
            // 
            // myButton8
            // 
            this.myButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton8.AutoSize = true;
            this.myButton8.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton8.Location = new System.Drawing.Point(0, 46);
            this.myButton8.Margin = new System.Windows.Forms.Padding(0);
            this.myButton8.Name = "myButton8";
            this.myButton8.Size = new System.Drawing.Size(49, 46);
            this.myButton8.TabIndex = 7;
            this.myButton8.UseVisualStyleBackColor = false;
            // 
            // myButton7
            // 
            this.myButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton7.AutoSize = true;
            this.myButton7.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton7.Location = new System.Drawing.Point(294, 0);
            this.myButton7.Margin = new System.Windows.Forms.Padding(0);
            this.myButton7.Name = "myButton7";
            this.myButton7.Size = new System.Drawing.Size(55, 46);
            this.myButton7.TabIndex = 6;
            this.myButton7.UseVisualStyleBackColor = false;
            // 
            // myButton6
            // 
            this.myButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton6.AutoSize = true;
            this.myButton6.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton6.Location = new System.Drawing.Point(245, 0);
            this.myButton6.Margin = new System.Windows.Forms.Padding(0);
            this.myButton6.Name = "myButton6";
            this.myButton6.Size = new System.Drawing.Size(49, 46);
            this.myButton6.TabIndex = 5;
            this.myButton6.UseVisualStyleBackColor = false;
            // 
            // myButton5
            // 
            this.myButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton5.AutoSize = true;
            this.myButton5.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton5.Location = new System.Drawing.Point(196, 0);
            this.myButton5.Margin = new System.Windows.Forms.Padding(0);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(49, 46);
            this.myButton5.TabIndex = 4;
            this.myButton5.UseVisualStyleBackColor = false;
            // 
            // myButton4
            // 
            this.myButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton4.AutoSize = true;
            this.myButton4.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton4.Location = new System.Drawing.Point(147, 0);
            this.myButton4.Margin = new System.Windows.Forms.Padding(0);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(49, 46);
            this.myButton4.TabIndex = 3;
            this.myButton4.UseVisualStyleBackColor = false;
            // 
            // myButton3
            // 
            this.myButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton3.AutoSize = true;
            this.myButton3.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton3.Location = new System.Drawing.Point(98, 0);
            this.myButton3.Margin = new System.Windows.Forms.Padding(0);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(49, 46);
            this.myButton3.TabIndex = 2;
            this.myButton3.UseVisualStyleBackColor = false;
            // 
            // myButton2
            // 
            this.myButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton2.AutoSize = true;
            this.myButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton2.Location = new System.Drawing.Point(49, 0);
            this.myButton2.Margin = new System.Windows.Forms.Padding(0);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(49, 46);
            this.myButton2.TabIndex = 1;
            this.myButton2.UseVisualStyleBackColor = false;
            // 
            // myButton1
            // 
            this.myButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton1.AutoSize = true;
            this.myButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton1.Location = new System.Drawing.Point(0, 0);
            this.myButton1.Margin = new System.Windows.Forms.Padding(0);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(49, 46);
            this.myButton1.TabIndex = 0;
            this.myButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game in a process!";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.myButton50, 6, 6);
            this.tableLayoutPanel2.Controls.Add(this.myButton51, 5, 6);
            this.tableLayoutPanel2.Controls.Add(this.myButton52, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.myButton53, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.myButton54, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.myButton55, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.myButton56, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.myButton57, 6, 5);
            this.tableLayoutPanel2.Controls.Add(this.myButton58, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.myButton59, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.myButton60, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.myButton61, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.myButton62, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.myButton63, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.myButton64, 6, 4);
            this.tableLayoutPanel2.Controls.Add(this.myButton65, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.myButton66, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.myButton67, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.myButton68, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.myButton69, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.myButton70, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.myButton71, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.myButton72, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.myButton73, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.myButton74, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.myButton75, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.myButton76, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.myButton77, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.myButton78, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.myButton79, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.myButton80, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.myButton81, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.myButton82, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.myButton83, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.myButton84, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.myButton85, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.myButton86, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.myButton87, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.myButton88, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.myButton89, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.myButton90, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.myButton91, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.myButton92, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.myButton93, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.myButton94, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.myButton95, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.myButton96, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.myButton97, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.myButton98, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(730, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(349, 328);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // myButton50
            // 
            this.myButton50.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton50.AutoSize = true;
            this.myButton50.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton50.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton50.Location = new System.Drawing.Point(294, 276);
            this.myButton50.Margin = new System.Windows.Forms.Padding(0);
            this.myButton50.Name = "myButton50";
            this.myButton50.Size = new System.Drawing.Size(55, 52);
            this.myButton50.TabIndex = 48;
            this.myButton50.UseVisualStyleBackColor = false;
            // 
            // myButton51
            // 
            this.myButton51.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton51.AutoSize = true;
            this.myButton51.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton51.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton51.Location = new System.Drawing.Point(245, 276);
            this.myButton51.Margin = new System.Windows.Forms.Padding(0);
            this.myButton51.Name = "myButton51";
            this.myButton51.Size = new System.Drawing.Size(49, 52);
            this.myButton51.TabIndex = 47;
            this.myButton51.UseVisualStyleBackColor = false;
            // 
            // myButton52
            // 
            this.myButton52.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton52.AutoSize = true;
            this.myButton52.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton52.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton52.Location = new System.Drawing.Point(196, 276);
            this.myButton52.Margin = new System.Windows.Forms.Padding(0);
            this.myButton52.Name = "myButton52";
            this.myButton52.Size = new System.Drawing.Size(49, 52);
            this.myButton52.TabIndex = 46;
            this.myButton52.UseVisualStyleBackColor = false;
            // 
            // myButton53
            // 
            this.myButton53.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton53.AutoSize = true;
            this.myButton53.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton53.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton53.Location = new System.Drawing.Point(147, 276);
            this.myButton53.Margin = new System.Windows.Forms.Padding(0);
            this.myButton53.Name = "myButton53";
            this.myButton53.Size = new System.Drawing.Size(49, 52);
            this.myButton53.TabIndex = 45;
            this.myButton53.UseVisualStyleBackColor = false;
            // 
            // myButton54
            // 
            this.myButton54.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton54.AutoSize = true;
            this.myButton54.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton54.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton54.Location = new System.Drawing.Point(98, 276);
            this.myButton54.Margin = new System.Windows.Forms.Padding(0);
            this.myButton54.Name = "myButton54";
            this.myButton54.Size = new System.Drawing.Size(49, 52);
            this.myButton54.TabIndex = 44;
            this.myButton54.UseVisualStyleBackColor = false;
            // 
            // myButton55
            // 
            this.myButton55.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton55.AutoSize = true;
            this.myButton55.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton55.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton55.Location = new System.Drawing.Point(49, 276);
            this.myButton55.Margin = new System.Windows.Forms.Padding(0);
            this.myButton55.Name = "myButton55";
            this.myButton55.Size = new System.Drawing.Size(49, 52);
            this.myButton55.TabIndex = 43;
            this.myButton55.UseVisualStyleBackColor = false;
            // 
            // myButton56
            // 
            this.myButton56.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton56.AutoSize = true;
            this.myButton56.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton56.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton56.Location = new System.Drawing.Point(0, 276);
            this.myButton56.Margin = new System.Windows.Forms.Padding(0);
            this.myButton56.Name = "myButton56";
            this.myButton56.Size = new System.Drawing.Size(49, 52);
            this.myButton56.TabIndex = 42;
            this.myButton56.UseVisualStyleBackColor = false;
            // 
            // myButton57
            // 
            this.myButton57.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton57.AutoSize = true;
            this.myButton57.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton57.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton57.Location = new System.Drawing.Point(294, 230);
            this.myButton57.Margin = new System.Windows.Forms.Padding(0);
            this.myButton57.Name = "myButton57";
            this.myButton57.Size = new System.Drawing.Size(55, 46);
            this.myButton57.TabIndex = 41;
            this.myButton57.UseVisualStyleBackColor = false;
            // 
            // myButton58
            // 
            this.myButton58.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton58.AutoSize = true;
            this.myButton58.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton58.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton58.Location = new System.Drawing.Point(245, 230);
            this.myButton58.Margin = new System.Windows.Forms.Padding(0);
            this.myButton58.Name = "myButton58";
            this.myButton58.Size = new System.Drawing.Size(49, 46);
            this.myButton58.TabIndex = 40;
            this.myButton58.UseVisualStyleBackColor = false;
            // 
            // myButton59
            // 
            this.myButton59.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton59.AutoSize = true;
            this.myButton59.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton59.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton59.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton59.Location = new System.Drawing.Point(196, 230);
            this.myButton59.Margin = new System.Windows.Forms.Padding(0);
            this.myButton59.Name = "myButton59";
            this.myButton59.Size = new System.Drawing.Size(49, 46);
            this.myButton59.TabIndex = 39;
            this.myButton59.UseVisualStyleBackColor = false;
            // 
            // myButton60
            // 
            this.myButton60.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton60.AutoSize = true;
            this.myButton60.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton60.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton60.Location = new System.Drawing.Point(147, 230);
            this.myButton60.Margin = new System.Windows.Forms.Padding(0);
            this.myButton60.Name = "myButton60";
            this.myButton60.Size = new System.Drawing.Size(49, 46);
            this.myButton60.TabIndex = 38;
            this.myButton60.UseVisualStyleBackColor = false;
            // 
            // myButton61
            // 
            this.myButton61.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton61.AutoSize = true;
            this.myButton61.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton61.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton61.Location = new System.Drawing.Point(98, 230);
            this.myButton61.Margin = new System.Windows.Forms.Padding(0);
            this.myButton61.Name = "myButton61";
            this.myButton61.Size = new System.Drawing.Size(49, 46);
            this.myButton61.TabIndex = 37;
            this.myButton61.UseVisualStyleBackColor = false;
            // 
            // myButton62
            // 
            this.myButton62.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton62.AutoSize = true;
            this.myButton62.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton62.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton62.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton62.Location = new System.Drawing.Point(49, 230);
            this.myButton62.Margin = new System.Windows.Forms.Padding(0);
            this.myButton62.Name = "myButton62";
            this.myButton62.Size = new System.Drawing.Size(49, 46);
            this.myButton62.TabIndex = 36;
            this.myButton62.UseVisualStyleBackColor = false;
            // 
            // myButton63
            // 
            this.myButton63.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton63.AutoSize = true;
            this.myButton63.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton63.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton63.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton63.Location = new System.Drawing.Point(0, 230);
            this.myButton63.Margin = new System.Windows.Forms.Padding(0);
            this.myButton63.Name = "myButton63";
            this.myButton63.Size = new System.Drawing.Size(49, 46);
            this.myButton63.TabIndex = 35;
            this.myButton63.UseVisualStyleBackColor = false;
            // 
            // myButton64
            // 
            this.myButton64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton64.AutoSize = true;
            this.myButton64.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton64.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton64.Location = new System.Drawing.Point(294, 184);
            this.myButton64.Margin = new System.Windows.Forms.Padding(0);
            this.myButton64.Name = "myButton64";
            this.myButton64.Size = new System.Drawing.Size(55, 46);
            this.myButton64.TabIndex = 34;
            this.myButton64.UseVisualStyleBackColor = false;
            // 
            // myButton65
            // 
            this.myButton65.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton65.AutoSize = true;
            this.myButton65.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton65.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton65.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton65.Location = new System.Drawing.Point(245, 184);
            this.myButton65.Margin = new System.Windows.Forms.Padding(0);
            this.myButton65.Name = "myButton65";
            this.myButton65.Size = new System.Drawing.Size(49, 46);
            this.myButton65.TabIndex = 33;
            this.myButton65.UseVisualStyleBackColor = false;
            // 
            // myButton66
            // 
            this.myButton66.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton66.AutoSize = true;
            this.myButton66.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton66.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton66.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton66.Location = new System.Drawing.Point(196, 184);
            this.myButton66.Margin = new System.Windows.Forms.Padding(0);
            this.myButton66.Name = "myButton66";
            this.myButton66.Size = new System.Drawing.Size(49, 46);
            this.myButton66.TabIndex = 32;
            this.myButton66.UseVisualStyleBackColor = false;
            // 
            // myButton67
            // 
            this.myButton67.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton67.AutoSize = true;
            this.myButton67.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton67.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton67.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton67.Location = new System.Drawing.Point(147, 184);
            this.myButton67.Margin = new System.Windows.Forms.Padding(0);
            this.myButton67.Name = "myButton67";
            this.myButton67.Size = new System.Drawing.Size(49, 46);
            this.myButton67.TabIndex = 31;
            this.myButton67.UseVisualStyleBackColor = false;
            // 
            // myButton68
            // 
            this.myButton68.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton68.AutoSize = true;
            this.myButton68.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton68.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton68.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton68.Location = new System.Drawing.Point(98, 184);
            this.myButton68.Margin = new System.Windows.Forms.Padding(0);
            this.myButton68.Name = "myButton68";
            this.myButton68.Size = new System.Drawing.Size(49, 46);
            this.myButton68.TabIndex = 30;
            this.myButton68.UseVisualStyleBackColor = false;
            // 
            // myButton69
            // 
            this.myButton69.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton69.AutoSize = true;
            this.myButton69.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton69.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton69.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton69.Location = new System.Drawing.Point(49, 184);
            this.myButton69.Margin = new System.Windows.Forms.Padding(0);
            this.myButton69.Name = "myButton69";
            this.myButton69.Size = new System.Drawing.Size(49, 46);
            this.myButton69.TabIndex = 29;
            this.myButton69.UseVisualStyleBackColor = false;
            // 
            // myButton70
            // 
            this.myButton70.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton70.AutoSize = true;
            this.myButton70.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton70.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton70.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton70.Location = new System.Drawing.Point(0, 184);
            this.myButton70.Margin = new System.Windows.Forms.Padding(0);
            this.myButton70.Name = "myButton70";
            this.myButton70.Size = new System.Drawing.Size(49, 46);
            this.myButton70.TabIndex = 28;
            this.myButton70.UseVisualStyleBackColor = false;
            // 
            // myButton71
            // 
            this.myButton71.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton71.AutoSize = true;
            this.myButton71.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton71.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton71.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton71.Location = new System.Drawing.Point(294, 138);
            this.myButton71.Margin = new System.Windows.Forms.Padding(0);
            this.myButton71.Name = "myButton71";
            this.myButton71.Size = new System.Drawing.Size(55, 46);
            this.myButton71.TabIndex = 27;
            this.myButton71.UseVisualStyleBackColor = false;
            // 
            // myButton72
            // 
            this.myButton72.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton72.AutoSize = true;
            this.myButton72.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton72.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton72.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton72.Location = new System.Drawing.Point(245, 138);
            this.myButton72.Margin = new System.Windows.Forms.Padding(0);
            this.myButton72.Name = "myButton72";
            this.myButton72.Size = new System.Drawing.Size(49, 46);
            this.myButton72.TabIndex = 26;
            this.myButton72.UseVisualStyleBackColor = false;
            // 
            // myButton73
            // 
            this.myButton73.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton73.AutoSize = true;
            this.myButton73.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton73.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton73.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton73.Location = new System.Drawing.Point(196, 138);
            this.myButton73.Margin = new System.Windows.Forms.Padding(0);
            this.myButton73.Name = "myButton73";
            this.myButton73.Size = new System.Drawing.Size(49, 46);
            this.myButton73.TabIndex = 25;
            this.myButton73.UseVisualStyleBackColor = false;
            // 
            // myButton74
            // 
            this.myButton74.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton74.AutoSize = true;
            this.myButton74.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton74.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton74.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton74.Location = new System.Drawing.Point(147, 138);
            this.myButton74.Margin = new System.Windows.Forms.Padding(0);
            this.myButton74.Name = "myButton74";
            this.myButton74.Size = new System.Drawing.Size(49, 46);
            this.myButton74.TabIndex = 24;
            this.myButton74.UseVisualStyleBackColor = false;
            // 
            // myButton75
            // 
            this.myButton75.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton75.AutoSize = true;
            this.myButton75.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton75.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton75.Location = new System.Drawing.Point(98, 138);
            this.myButton75.Margin = new System.Windows.Forms.Padding(0);
            this.myButton75.Name = "myButton75";
            this.myButton75.Size = new System.Drawing.Size(49, 46);
            this.myButton75.TabIndex = 23;
            this.myButton75.UseVisualStyleBackColor = false;
            // 
            // myButton76
            // 
            this.myButton76.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton76.AutoSize = true;
            this.myButton76.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton76.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton76.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton76.Location = new System.Drawing.Point(49, 138);
            this.myButton76.Margin = new System.Windows.Forms.Padding(0);
            this.myButton76.Name = "myButton76";
            this.myButton76.Size = new System.Drawing.Size(49, 46);
            this.myButton76.TabIndex = 22;
            this.myButton76.UseVisualStyleBackColor = false;
            // 
            // myButton77
            // 
            this.myButton77.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton77.AutoSize = true;
            this.myButton77.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton77.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton77.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton77.Location = new System.Drawing.Point(0, 138);
            this.myButton77.Margin = new System.Windows.Forms.Padding(0);
            this.myButton77.Name = "myButton77";
            this.myButton77.Size = new System.Drawing.Size(49, 46);
            this.myButton77.TabIndex = 21;
            this.myButton77.UseVisualStyleBackColor = false;
            // 
            // myButton78
            // 
            this.myButton78.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton78.AutoSize = true;
            this.myButton78.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton78.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton78.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton78.Location = new System.Drawing.Point(294, 92);
            this.myButton78.Margin = new System.Windows.Forms.Padding(0);
            this.myButton78.Name = "myButton78";
            this.myButton78.Size = new System.Drawing.Size(55, 46);
            this.myButton78.TabIndex = 20;
            this.myButton78.UseVisualStyleBackColor = false;
            // 
            // myButton79
            // 
            this.myButton79.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton79.AutoSize = true;
            this.myButton79.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton79.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton79.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton79.Location = new System.Drawing.Point(245, 92);
            this.myButton79.Margin = new System.Windows.Forms.Padding(0);
            this.myButton79.Name = "myButton79";
            this.myButton79.Size = new System.Drawing.Size(49, 46);
            this.myButton79.TabIndex = 19;
            this.myButton79.UseVisualStyleBackColor = false;
            // 
            // myButton80
            // 
            this.myButton80.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton80.AutoSize = true;
            this.myButton80.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton80.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton80.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton80.Location = new System.Drawing.Point(196, 92);
            this.myButton80.Margin = new System.Windows.Forms.Padding(0);
            this.myButton80.Name = "myButton80";
            this.myButton80.Size = new System.Drawing.Size(49, 46);
            this.myButton80.TabIndex = 18;
            this.myButton80.UseVisualStyleBackColor = false;
            // 
            // myButton81
            // 
            this.myButton81.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton81.AutoSize = true;
            this.myButton81.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton81.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton81.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton81.Location = new System.Drawing.Point(147, 92);
            this.myButton81.Margin = new System.Windows.Forms.Padding(0);
            this.myButton81.Name = "myButton81";
            this.myButton81.Size = new System.Drawing.Size(49, 46);
            this.myButton81.TabIndex = 17;
            this.myButton81.UseVisualStyleBackColor = false;
            // 
            // myButton82
            // 
            this.myButton82.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton82.AutoSize = true;
            this.myButton82.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton82.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton82.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton82.Location = new System.Drawing.Point(98, 92);
            this.myButton82.Margin = new System.Windows.Forms.Padding(0);
            this.myButton82.Name = "myButton82";
            this.myButton82.Size = new System.Drawing.Size(49, 46);
            this.myButton82.TabIndex = 16;
            this.myButton82.UseVisualStyleBackColor = false;
            // 
            // myButton83
            // 
            this.myButton83.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton83.AutoSize = true;
            this.myButton83.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton83.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton83.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton83.Location = new System.Drawing.Point(49, 92);
            this.myButton83.Margin = new System.Windows.Forms.Padding(0);
            this.myButton83.Name = "myButton83";
            this.myButton83.Size = new System.Drawing.Size(49, 46);
            this.myButton83.TabIndex = 15;
            this.myButton83.UseVisualStyleBackColor = false;
            // 
            // myButton84
            // 
            this.myButton84.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton84.AutoSize = true;
            this.myButton84.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton84.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton84.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton84.Location = new System.Drawing.Point(0, 92);
            this.myButton84.Margin = new System.Windows.Forms.Padding(0);
            this.myButton84.Name = "myButton84";
            this.myButton84.Size = new System.Drawing.Size(49, 46);
            this.myButton84.TabIndex = 14;
            this.myButton84.UseVisualStyleBackColor = false;
            // 
            // myButton85
            // 
            this.myButton85.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton85.AutoSize = true;
            this.myButton85.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton85.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton85.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton85.Location = new System.Drawing.Point(294, 46);
            this.myButton85.Margin = new System.Windows.Forms.Padding(0);
            this.myButton85.Name = "myButton85";
            this.myButton85.Size = new System.Drawing.Size(55, 46);
            this.myButton85.TabIndex = 13;
            this.myButton85.UseVisualStyleBackColor = false;
            // 
            // myButton86
            // 
            this.myButton86.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton86.AutoSize = true;
            this.myButton86.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton86.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton86.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton86.Location = new System.Drawing.Point(245, 46);
            this.myButton86.Margin = new System.Windows.Forms.Padding(0);
            this.myButton86.Name = "myButton86";
            this.myButton86.Size = new System.Drawing.Size(49, 46);
            this.myButton86.TabIndex = 12;
            this.myButton86.UseVisualStyleBackColor = false;
            // 
            // myButton87
            // 
            this.myButton87.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton87.AutoSize = true;
            this.myButton87.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton87.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton87.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton87.Location = new System.Drawing.Point(196, 46);
            this.myButton87.Margin = new System.Windows.Forms.Padding(0);
            this.myButton87.Name = "myButton87";
            this.myButton87.Size = new System.Drawing.Size(49, 46);
            this.myButton87.TabIndex = 11;
            this.myButton87.UseVisualStyleBackColor = false;
            // 
            // myButton88
            // 
            this.myButton88.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton88.AutoSize = true;
            this.myButton88.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton88.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton88.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton88.Location = new System.Drawing.Point(147, 46);
            this.myButton88.Margin = new System.Windows.Forms.Padding(0);
            this.myButton88.Name = "myButton88";
            this.myButton88.Size = new System.Drawing.Size(49, 46);
            this.myButton88.TabIndex = 10;
            this.myButton88.UseVisualStyleBackColor = false;
            // 
            // myButton89
            // 
            this.myButton89.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton89.AutoSize = true;
            this.myButton89.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton89.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton89.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton89.Location = new System.Drawing.Point(98, 46);
            this.myButton89.Margin = new System.Windows.Forms.Padding(0);
            this.myButton89.Name = "myButton89";
            this.myButton89.Size = new System.Drawing.Size(49, 46);
            this.myButton89.TabIndex = 9;
            this.myButton89.UseVisualStyleBackColor = false;
            // 
            // myButton90
            // 
            this.myButton90.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton90.AutoSize = true;
            this.myButton90.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton90.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton90.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton90.Location = new System.Drawing.Point(49, 46);
            this.myButton90.Margin = new System.Windows.Forms.Padding(0);
            this.myButton90.Name = "myButton90";
            this.myButton90.Size = new System.Drawing.Size(49, 46);
            this.myButton90.TabIndex = 8;
            this.myButton90.UseVisualStyleBackColor = false;
            // 
            // myButton91
            // 
            this.myButton91.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton91.AutoSize = true;
            this.myButton91.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton91.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton91.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton91.Location = new System.Drawing.Point(0, 46);
            this.myButton91.Margin = new System.Windows.Forms.Padding(0);
            this.myButton91.Name = "myButton91";
            this.myButton91.Size = new System.Drawing.Size(49, 46);
            this.myButton91.TabIndex = 7;
            this.myButton91.UseVisualStyleBackColor = false;
            // 
            // myButton92
            // 
            this.myButton92.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton92.AutoSize = true;
            this.myButton92.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton92.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton92.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton92.Location = new System.Drawing.Point(294, 0);
            this.myButton92.Margin = new System.Windows.Forms.Padding(0);
            this.myButton92.Name = "myButton92";
            this.myButton92.Size = new System.Drawing.Size(55, 46);
            this.myButton92.TabIndex = 6;
            this.myButton92.UseVisualStyleBackColor = false;
            // 
            // myButton93
            // 
            this.myButton93.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton93.AutoSize = true;
            this.myButton93.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton93.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton93.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton93.Location = new System.Drawing.Point(245, 0);
            this.myButton93.Margin = new System.Windows.Forms.Padding(0);
            this.myButton93.Name = "myButton93";
            this.myButton93.Size = new System.Drawing.Size(49, 46);
            this.myButton93.TabIndex = 5;
            this.myButton93.UseVisualStyleBackColor = false;
            // 
            // myButton94
            // 
            this.myButton94.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton94.AutoSize = true;
            this.myButton94.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton94.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton94.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton94.Location = new System.Drawing.Point(196, 0);
            this.myButton94.Margin = new System.Windows.Forms.Padding(0);
            this.myButton94.Name = "myButton94";
            this.myButton94.Size = new System.Drawing.Size(49, 46);
            this.myButton94.TabIndex = 4;
            this.myButton94.UseVisualStyleBackColor = false;
            // 
            // myButton95
            // 
            this.myButton95.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton95.AutoSize = true;
            this.myButton95.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton95.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton95.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton95.Location = new System.Drawing.Point(147, 0);
            this.myButton95.Margin = new System.Windows.Forms.Padding(0);
            this.myButton95.Name = "myButton95";
            this.myButton95.Size = new System.Drawing.Size(49, 46);
            this.myButton95.TabIndex = 3;
            this.myButton95.UseVisualStyleBackColor = false;
            // 
            // myButton96
            // 
            this.myButton96.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton96.AutoSize = true;
            this.myButton96.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton96.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton96.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton96.Location = new System.Drawing.Point(98, 0);
            this.myButton96.Margin = new System.Windows.Forms.Padding(0);
            this.myButton96.Name = "myButton96";
            this.myButton96.Size = new System.Drawing.Size(49, 46);
            this.myButton96.TabIndex = 2;
            this.myButton96.UseVisualStyleBackColor = false;
            // 
            // myButton97
            // 
            this.myButton97.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton97.AutoSize = true;
            this.myButton97.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton97.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton97.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton97.Location = new System.Drawing.Point(49, 0);
            this.myButton97.Margin = new System.Windows.Forms.Padding(0);
            this.myButton97.Name = "myButton97";
            this.myButton97.Size = new System.Drawing.Size(49, 46);
            this.myButton97.TabIndex = 1;
            this.myButton97.UseVisualStyleBackColor = false;
            // 
            // myButton98
            // 
            this.myButton98.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton98.AutoSize = true;
            this.myButton98.BackColor = System.Drawing.SystemColors.Highlight;
            this.myButton98.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myButton98.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton98.Location = new System.Drawing.Point(0, 0);
            this.myButton98.Margin = new System.Windows.Forms.Padding(0);
            this.myButton98.Name = "myButton98";
            this.myButton98.Size = new System.Drawing.Size(49, 46);
            this.myButton98.TabIndex = 0;
            this.myButton98.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(932, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your\'s Field";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Solid", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oponent\'s Field";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Random position";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "Restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 181);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Подсказка";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Kolmagorov_Battleships
            // 
            this.ClientSize = new System.Drawing.Size(1137, 500);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kolmagorov_Battleships";
            this.Text = "Battleships_Kolmagorov";
            this.Load += new System.EventHandler(this.Kolmagorov_Battleships_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // здесь он явно определяет все элементы формы
        public TableLayoutPanel tableLayoutPanel1;
        private MyButton myButton49;
        private MyButton myButton48;
        private MyButton myButton47;
        private MyButton myButton46;
        private MyButton myButton45;
        private MyButton myButton44;
        private MyButton myButton43;
        private MyButton myButton42;
        private MyButton myButton41;
        private MyButton myButton40;
        private MyButton myButton39;
        private MyButton myButton38;
        private MyButton myButton37;
        private MyButton myButton36;
        private MyButton myButton35;
        private MyButton myButton34;
        private MyButton myButton33;
        private MyButton myButton32;
        private MyButton myButton31;
        private MyButton myButton30;
        private MyButton myButton29;
        private MyButton myButton28;
        private MyButton myButton27;
        private MyButton myButton26;
        private MyButton myButton25;
        private MyButton myButton24;
        private MyButton myButton23;
        private MyButton myButton22;
        private MyButton myButton21;
        private MyButton myButton20;
        private MyButton myButton19;
        private MyButton myButton18;
        private MyButton myButton17;
        private MyButton myButton16;
        private MyButton myButton15;
        private MyButton myButton14;
        private MyButton myButton13;
        private MyButton myButton12;
        private MyButton myButton11;
        private MyButton myButton10;
        private MyButton myButton9;
        private MyButton myButton8;
        private MyButton myButton7;
        private MyButton myButton6;
        private MyButton myButton5;
        private MyButton myButton4;
        private MyButton myButton3;
        private MyButton myButton2;
        private MyButton myButton1;
        public TableLayoutPanel tableLayoutPanel2;
        private MyButton myButton50;
        private MyButton myButton51;
        private MyButton myButton52;
        private MyButton myButton53;
        private MyButton myButton54;
        private MyButton myButton55;
        private MyButton myButton56;
        private MyButton myButton57;
        private MyButton myButton58;
        private MyButton myButton59;
        private MyButton myButton60;
        private MyButton myButton61;
        private MyButton myButton62;
        private MyButton myButton63;
        private MyButton myButton64;
        private MyButton myButton65;
        private MyButton myButton66;
        private MyButton myButton67;
        private MyButton myButton68;
        private MyButton myButton69;
        private MyButton myButton70;
        private MyButton myButton71;
        private MyButton myButton72;
        private MyButton myButton73;
        private MyButton myButton74;
        private MyButton myButton75;
        private MyButton myButton76;
        private MyButton myButton77;
        private MyButton myButton78;
        private MyButton myButton79;
        private MyButton myButton80;
        private MyButton myButton81;
        private MyButton myButton82;
        private MyButton myButton83;
        private MyButton myButton84;
        private MyButton myButton85;
        private MyButton myButton86;
        private MyButton myButton87;
        private MyButton myButton88;
        private MyButton myButton89;
        private MyButton myButton90;
        private MyButton myButton91;
        private MyButton myButton92;
        private MyButton myButton93;
        private MyButton myButton94;
        private MyButton myButton95;
        private MyButton myButton96;
        private MyButton myButton97;
        private MyButton myButton98;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Random gen = new Random();




//////////////////////////////////////////////////////////// Доп методы

        private void SetShips(int field) // field = 1 для расстановки кораблей врага, field = 0 для наших кораблей
        {
            if (field == 1)
            {
                int i = 0;
                while (i < 4) // четыре однопалубника
                {
                    int cur = (int)(gen.NextDouble() * 49);
                    if (MyButton.Btns[cur].state == States.ship || MyButton.Btns[cur].state == States.aroundship) continue;
                    MyButton.Btns[cur].state = States.ship;
                    //MyButton.Btns[cur].BackColor = System.Drawing.Color.Yellow; 
                    LinkedList<MyButton> arround = MyButton.NoteArroundOne
                        (tableLayoutPanel1.GetCellPosition(MyButton.Btns[cur]), cur);
                    Ship.ships.AddLast(new OnePointShip(MyButton.Btns[cur], arround));
                    i++;
                }
                i = 0;
                while (i < 3) // три двупалубника
                {
                    int cur = (int)(gen.NextDouble() * 49);
                    if (MyButton.Btns[cur].state == States.ship || MyButton.Btns[cur].state == States.aroundship) continue;
                    int cur2 = (int)(gen.NextDouble() * 2);
                    switch (cur2)
                    {
                        case 0: // растянется по горизонтали
                            if (tableLayoutPanel1.GetCellPosition(MyButton.Btns[cur]).Column != 0) cur2 = cur + 1;
                            else cur2 = cur - 1;
                            break;
                        case 1: // растянется по вертикали
                            if (tableLayoutPanel1.GetCellPosition(MyButton.Btns[cur]).Row != 0) cur2 = cur + 7;
                            else cur2 = cur - 7;
                            break;
                        default: break;
                    }
                    if (MyButton.Btns[cur2].state == States.ship || MyButton.Btns[cur2].state == States.aroundship) continue;

                    MyButton.Btns[cur].state = States.ship;
                    MyButton.Btns[cur2].state = States.ship;
                    //MyButton.Btns[cur].BackColor = System.Drawing.Color.Yellow;
                    //MyButton.Btns[cur2].BackColor = System.Drawing.Color.Yellow;
                    LinkedList<MyButton> arround = MyButton.NoteArroundTwo
                        (tableLayoutPanel1.GetCellPosition(MyButton.Btns[cur]),
                        tableLayoutPanel1.GetCellPosition(MyButton.Btns[cur2]), cur, cur2);
                    Ship.ships.AddLast(new TwoPointShip(MyButton.Btns[cur], MyButton.Btns[cur2], arround));
                    i++;
                }

            }
            else
            {
                int i = 0;
                while (i < 4) // четыре однопалубника
                {
                    int cur = (int)(gen.NextDouble() * 49);
                    if (MyButton.MBtns[cur].state == States.ship || MyButton.MBtns[cur].state == States.aroundship) continue;
                    MyButton.MBtns[cur].state = States.ship;
                    MyButton.MBtns[cur].BackColor = System.Drawing.Color.Yellow;  // удали потом
                    LinkedList<MyButton> arround = MyButton.MNoteArroundOne
                        (tableLayoutPanel2.GetCellPosition(MyButton.MBtns[cur]), cur);
                    Ship.Mships.AddLast(new OnePointShip(MyButton.MBtns[cur], arround));
                    i++;
                }
                i = 0;
                while (i < 3) // три двупалубника
                {
                    int cur = (int)(gen.NextDouble() * 49);
                    if (MyButton.MBtns[cur].state == States.ship || MyButton.MBtns[cur].state == States.aroundship) continue;
                    int cur2 = (int)(gen.NextDouble() * 2);
                    switch (cur2)
                    {
                        case 0: // растянется по горизонтали
                            if (tableLayoutPanel2.GetCellPosition(MyButton.MBtns[cur]).Column != 0) cur2 = cur + 1;
                            else cur2 = cur - 1;
                            break;
                        case 1: // растянется по вертикали
                            if (tableLayoutPanel2.GetCellPosition(MyButton.MBtns[cur]).Row != 0) cur2 = cur + 7;
                            else cur2 = cur - 7;
                            break;
                        default: break;
                    }
                    if (MyButton.MBtns[cur2].state == States.ship || MyButton.MBtns[cur2].state == States.aroundship) continue;

                    MyButton.MBtns[cur].state = States.ship;
                    MyButton.MBtns[cur2].state = States.ship;
                    MyButton.MBtns[cur].BackColor = System.Drawing.Color.Yellow;  // удали потом
                    MyButton.MBtns[cur2].BackColor = System.Drawing.Color.Yellow;  // удали потом
                    LinkedList<MyButton> arround = MyButton.MNoteArroundTwo
                        (tableLayoutPanel2.GetCellPosition(MyButton.MBtns[cur]),
                        tableLayoutPanel2.GetCellPosition(MyButton.MBtns[cur2]), cur, cur2);
                    Ship.Mships.AddLast(new TwoPointShip(MyButton.MBtns[cur], MyButton.MBtns[cur2], arround));
                    i++;
                }

            }
        }

        private Button button4;
    }
}

