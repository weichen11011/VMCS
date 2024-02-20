using System.Diagnostics.Metrics;

namespace B32_Virtual_Machine
{
    public partial class MainForm : Form
    {
        private byte[] B32Memory;  //64kmemory
        private ushort StartAddr;  //起始位址
        private ushort ExecAddr;   //執行位址
        private ushort InstructionPointer; //下一個要被執行的byte在哪裡
        private byte Register_A;
        private byte Register_B;
        private ushort Register_X;
        private ushort Register_Y;
        private ushort Register_D;

        public MainForm()
        {
            InitializeComponent();
            B32Memory = new byte[65535];
            StartAddr = 0;
            ExecAddr = 0;
            Register_A = 0;
            Register_B = 0;
            Register_D = 0;
            Register_X = 0;
            Register_Y = 0;
            UpdateRegisterStatus();
        }

        private void UpdateRegisterStatus()
        {
            string strRegisters = "";
            strRegisters = "Register A = $" +
           Register_A.ToString("X").PadLeft(2, '0');
            strRegisters += " Register B = $" +
           Register_B.ToString("X").PadLeft(2, '0');
            strRegisters += " Register D = $" +
           Register_D.ToString("X").PadLeft(4, '0');
            strRegisters += "\nRegister X = $" +
           Register_X.ToString("X").PadLeft(4, '0');
            strRegisters += " Register Y = $" +
           Register_Y.ToString("X").PadLeft(4, '0');
            strRegisters += " Instruction Pointer = $" +
           InstructionPointer.ToString("X").PadLeft(4, '0');
            this.lblRegisters.Text = strRegisters;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte Magic1;
            byte Magic2;
            byte Magic3;
            openFileDialog1.ShowDialog();
            System.IO.BinaryReader br;
            System.IO.FileStream fs = new
            System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open);
            br = new System.IO.BinaryReader(fs);
            Magic1 = br.ReadByte();
            Magic2 = br.ReadByte();
            Magic3 = br.ReadByte();
            if (Magic1 != 'B' && Magic2 != '3' && Magic3 != '2')
            {
                MessageBox.Show("This is not a valid B32 file!", "Error!",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StartAddr = br.ReadUInt16();
            ExecAddr = br.ReadUInt16();
            ushort Counter = 0;
            while ((br.PeekChar() != -1))
            {
                B32Memory[(StartAddr + Counter)] = br.ReadByte();
                Counter++;
            }
            br.Close();
            fs.Close();
            InstructionPointer = ExecAddr;
            ExecuteProgram(ExecAddr, Counter);
        }

        private void ExecuteProgram(ushort ExecAddr, ushort ProgLength)
        {
            ProgLength = 64000;
            while (ProgLength > 0)
            {
                byte Instruction = B32Memory[InstructionPointer];
                ProgLength--;
                if (Instruction == 0x02) // LDX #<value>
                {
                    Register_X = (ushort)((B32Memory[(InstructionPointer +
                   2)]) << 8);
                    Register_X += B32Memory[(InstructionPointer + 1)];
                    ProgLength -= 2;
                    InstructionPointer += 3;
                    UpdateRegisterStatus();
                    continue;
                }
                if (Instruction == 0x01) // LDA #<value>
                {
                    Register_A = B32Memory[(InstructionPointer + 1)];
                    SetRegisterD();
                    ProgLength -= 1;
                    InstructionPointer += 2;
                    UpdateRegisterStatus();
                    continue;
                }
                if (Instruction == 0x03) // STA ,X
                {
                    B32Memory[Register_X] = Register_A;
                    b32Screen1.Poke(Register_X, Register_A);
                    InstructionPointer++;
                    UpdateRegisterStatus();
                    continue;
                }
                if (Instruction == 0x04) // END 
                {
                    InstructionPointer++;
                    UpdateRegisterStatus();
                    break;
                }
            }


        }

        private void SetRegisterD()
        {
            Register_D = (ushort)(Register_A << 8 + Register_B);
        }


    }
}