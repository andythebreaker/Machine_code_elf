/*
 to do :
 負數還沒確認
 不要搞超過int大小，所有資料都用int
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instruction_editor
{
    public partial class Form1 : Form
    {
        int row_num = 0;

        void plugin(string st)
        {
            
            int i = richTextBox1.SelectionStart;
            richTextBox1.Focus();
            richTextBox1.Text = richTextBox1.Text.Insert(i, st);
            richTextBox1.Select(i + st.Length, 0);
        }
        public Form1()
        {
            InitializeComponent();
            button1.Text = "BRA";
            button3.Text = "LD";
            button4.Text = "STR";
            
            button6.Text = "ADD";
            button7.Text = "MUL";
            button8.Text = "CMP";
            button9.Text = "SHF";
            button10.Text = "ROT";
            button11.Text = "HLT";
            button12.Text = "DIV";
            button13.Text = "RMD";
            checkBox1.Checked = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            era.Text = "";
            refresh_row_num();
            int ins_block_numb = 0;
            int last_n = -1;
            string[] ins = new string[4];
            for (int idx = 0; idx < 4; idx++)
            {
                ins[idx] = "";
            }
            int blank = 0;
            int count_row = 1;
            for (int i = 0; i < richTextBox1.TextLength; i++)
            {
                switch (richTextBox1.Text[i])
                {
                    case '\n':
                        if (ins_block_numb == 3)
                        {
                            for (int i_add = blank + 1; i_add < i; i_add++)
                            {
                                ins[ins_block_numb] = ins[ins_block_numb] + richTextBox1.Text[i_add];
                            }
                            string temp_str = "";
                            for (int idx = 0; idx < 4; idx++)
                            {
                                temp_str = temp_str + ins[idx] + " ";
                            }
                            //richTextBox2.Text = richTextBox2.Text + temp_str + "\n";//<!>
                            string bit = "";
                            switch (ins[0])
                            {
                                case "NOP":
                                    bit = "0000";
                                    break;
                                case "BRA":
                                    bit = "0001";
                                    break;
                                case "LD":
                                    bit = "0010";
                                    break;
                                case "STR":
                                    bit = "0011";
                                    break;
                                case "ADD":
                                    bit = "0100";
                                    break;
                                case "MUL":
                                    bit = "0101";
                                    break;
                                case "CMP":
                                    bit = "0110";
                                    break;
                                case "SHF":
                                    bit = "0111";
                                    break;
                                case "ROT":
                                    bit = "1000";
                                    break;
                                case "HLT":
                                    bit = "1001";
                                    break;
                                case "DIV":
                                    bit = "1010";
                                    break;
                                case "RMD":
                                    bit = "1011";
                                    break;
                                default:
                                    era.Text = "[opcode] syntax error! " + "@ " + "row: " + count_row.ToString();
                                    break;
                            }
                            string b2 = "";
                            string b3 = "";
                            string b4 = "";
                            string binary_temp = Convert.ToString(Convert.ToInt32(ins[1]/*number*/, 10/*fromBase*/), 2/*toBase*/);
                            switch (binary_temp.Length)
                            {
                                case 0:
                                    b2 = "0000";
                                    break;
                                case 1:
                                    b2 = "000" + binary_temp;
                                    break;
                                case 2:
                                    b2 = "00" + binary_temp;
                                    break;
                                case 3:
                                    b2 = "0" + binary_temp;
                                    break;
                                case 4:
                                    b2 = binary_temp;
                                    break;
                                default:
                                    era.Text = "[CONDcode] syntax error! " + "@ " + "row: " + count_row.ToString();
                                    break;
                            }
                            binary_temp = Convert.ToString(Convert.ToInt32(ins[2]/*number*/, 10/*fromBase*/), 2/*toBase*/);
                            if (binary_temp.Length <= 12) { 
                            for (int binary_temp_inx = 0; binary_temp_inx < 12 - binary_temp.Length; binary_temp_inx++)
                            {
                                b3 = b3 + "0";
                            }
                            }
                            else
                            {
                                era.Text = "[source address] syntax error! " + "@ " + "row: " + count_row.ToString();
                            }
                            b3 = b3 + binary_temp;
                            binary_temp = Convert.ToString(Convert.ToInt32(ins[3]/*number*/, 10/*fromBase*/), 2/*toBase*/);
                            if (binary_temp.Length <= 12)
                            {
                                for (int binary_temp_inx = 0; binary_temp_inx < 12 - binary_temp.Length; binary_temp_inx++)
                                {
                                    b4 = b4 + "0";
                                }
                            }
                            else
                            {
                                era.Text = "[destination address] syntax error! " + "@ " + "row: " + count_row.ToString();
                            }
                            b4 = b4 + binary_temp;

                            richTextBox2.Text = richTextBox2.Text + bit + b2 + b3 + b4 + "\n";
                        }
                        else
                        {
                            era.Text = "ERROR!! " + "@ " + "row: " + count_row.ToString();
                        }
                        last_n = i;
                        for (int idx = 0; idx < 4; idx++)
                        {
                            ins[idx] = "";
                        }
                        ins_block_numb = 0;
                        blank = 0;
                        count_row++;
                        break;
                    case ' ':

                        switch (ins_block_numb)
                        {
                            case 0:
                                for (int i_add = last_n + 1; i_add < i; i_add++)
                                {
                                    ins[ins_block_numb] = ins[ins_block_numb] + richTextBox1.Text[i_add];
                                }
                                break;
                            case 1:
                                for (int i_add = blank + 1; i_add < i; i_add++)
                                {
                                    ins[ins_block_numb] = ins[ins_block_numb] + richTextBox1.Text[i_add];
                                }
                                break;
                            case 2:
                                for (int i_add = blank + 1; i_add < i; i_add++)
                                {
                                    ins[ins_block_numb] = ins[ins_block_numb] + richTextBox1.Text[i_add];
                                }
                                break;
                            case 3:

                                break;
                            default:
                                era.Text = "ERROR!! " + "@ " + "row: " + count_row.ToString();
                                break;
                        }
                        blank = i;
                        ins_block_numb++;
                        break;
                    default:
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                SaveFileDialog save = new SaveFileDialog();

                save.FileName = "i_mem.txt";

                save.Filter = "Text File | *.txt";

                if (save.ShowDialog() == DialogResult.OK)

                {

                    StreamWriter writer = new StreamWriter(save.OpenFile());
                
                string rich_str_temp = "";
                int prev_loac =-1;
                for (int rich_idx = 0; rich_idx < richTextBox2.Text.Length; rich_idx++)
                {
                    if (richTextBox2.Text[rich_idx] == '\n')
                    {
                        for (int rich_idx_inside = prev_loac+1; rich_idx_inside < rich_idx; rich_idx_inside++)
                        {
                            rich_str_temp = rich_str_temp + richTextBox2.Text[rich_idx_inside];
                        }
                        writer.WriteLine(rich_str_temp);
                        prev_loac = rich_idx;
                        rich_str_temp = "";
                    }
                }

                    //writer.WriteLine("OK");
                    writer.Dispose();

                    writer.Close();

                }
                

        }

        void refresh_row_num()
        {
            row_num = 0;
            for (int i = 0; i < richTextBox1.TextLength; i++)
            {
                if (richTextBox1.Text[i] == '\n')
                {
                    row_num++;
                }
            }
            label1.Text = "行數:" + row_num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plugin("NOP");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            plugin("BRA");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            plugin("LD");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plugin("STR");
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            plugin("ADD");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            plugin("MUL");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            plugin("CMP");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            plugin("SHF");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            plugin("ROT");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            plugin("HLT");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            plugin("DIV");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            plugin("RMD");
        }

        private void cd0_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                plugin(" 0 ");
            }
            else
            {
                plugin("0");
            }
            
        }

        private void cd1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                plugin(" 1 ");
            }
            else
            {
                plugin("1");
            }
        }

        private void cd2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                plugin(" 2 ");
            }
            else
            {
                plugin("2");
            }
        }

        private void cd3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                plugin(" 3 ");
            }
            else
            {
                plugin("3");
            }
        }

        private void cd4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                plugin(" 4 ");
            }
            else
            {
                plugin("4");
            }
        }

        private void cd5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                plugin(" 5 ");
            }
            else
            {
                plugin("5");
            }
        }

        private void cc0_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                plugin(" 0 ");
            }
            else
            {
                plugin("0");
            }
        }

        private void cc8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                plugin(" 8 ");
            }
            else
            {
                plugin("8");
            }
        }

        private void sss_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "(Save source code)i_mem.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                string rich_str_temp = "";
                int prev_loac = -1;
                for (int rich_idx = 0; rich_idx < richTextBox1.Text.Length; rich_idx++)
                {
                    if (richTextBox1.Text[rich_idx] == '\n')
                    {
                        for (int rich_idx_inside = prev_loac + 1; rich_idx_inside < rich_idx; rich_idx_inside++)
                        {
                            rich_str_temp = rich_str_temp + richTextBox1.Text[rich_idx_inside];
                        }
                        writer.WriteLine(rich_str_temp);
                        prev_loac = rich_idx;
                        rich_str_temp = "";
                    }
                }
                //writer.WriteLine("OK");
                writer.Dispose();
                writer.Close();
            }
        }

        private void mem_in_TextChanged(object sender, EventArgs e)
        {
            mem_out.Text = "";
            row_numb_dispaly.Text = "";
            string numbers_being_processed_now = "";
            int last_matrix_indicator = -1;
            int row_numb_for_error = 0;
            for (int traversing_a_string = 0; traversing_a_string < mem_in.Text.Length; traversing_a_string++)
            {
                if (mem_in.Text[traversing_a_string]=='\n')
                {
                    row_numb_dispaly.Text = row_numb_dispaly.Text + row_numb_for_error.ToString()+"\n";
                    row_numb_for_error++;
                    for (int make_child_numbers = last_matrix_indicator+1; make_child_numbers < traversing_a_string; make_child_numbers++)
                    {
                        numbers_being_processed_now = numbers_being_processed_now + mem_in.Text[make_child_numbers];
                    }
                    last_matrix_indicator = traversing_a_string;
            string bin_temp = Convert.ToString(Convert.ToInt32(numbers_being_processed_now/*number*/, 10/*fromBase*/), 2/*toBase*/);
                    numbers_being_processed_now = "";
                    if (bin_temp.Length <= 32)
                    {
                        string two_bits_that_can_output = "";
                        for (int complement_32_bit = 0; complement_32_bit < 32- bin_temp.Length; complement_32_bit++)
                        {
                            two_bits_that_can_output = two_bits_that_can_output + "0";
                        }
                        two_bits_that_can_output = two_bits_that_can_output + bin_temp;
                        mem_out.Text = mem_out.Text + two_bits_that_can_output + "\n";
                    }
                    else
                    {
                        mem_error.Text = "ERROR!\n" +
                            "@ 行數:" +
                            row_numb_for_error.ToString() +
                            "Longer than 32";
                    }

                }
            }
        }

        private void mem_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "mem.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                string mem_out_temp = "";
                int prev_loac = -1;
                for (int mem_out_idx = 0; mem_out_idx < mem_out.Text.Length; mem_out_idx++)
                {
                    if (mem_out.Text[mem_out_idx] == '\n')
                    {
                        for (int mem_out_idx_inside = prev_loac + 1; mem_out_idx_inside < mem_out_idx; mem_out_idx_inside++)
                        {
                            mem_out_temp = mem_out_temp + mem_out.Text[mem_out_idx_inside];
                        }
                        writer.WriteLine(mem_out_temp);
                        prev_loac = mem_out_idx;
                        mem_out_temp = "";
                    }
                }
                //writer.WriteLine("OK");
                writer.Dispose();
                writer.Close();
            }
        }

        private void save_source_code_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "(source_code)mem.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                string mem_in_temp = "";
                int prev_loac = -1;
                for (int mem_in_idx = 0; mem_in_idx < mem_in.Text.Length; mem_in_idx++)
                {
                    if (mem_in.Text[mem_in_idx] == '\n')
                    {
                        for (int mem_in_idx_inside = prev_loac + 1; mem_in_idx_inside < mem_in_idx; mem_in_idx_inside++)
                        {
                            mem_in_temp = mem_in_temp + mem_in.Text[mem_in_idx_inside];
                        }
                        writer.WriteLine(mem_in_temp);
                        prev_loac = mem_in_idx;
                        mem_in_temp = "";
                    }
                }
                //writer.WriteLine("OK");
                writer.Dispose();
                writer.Close();
            }
        }
    }
}
