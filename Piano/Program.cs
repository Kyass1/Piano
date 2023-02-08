namespace Piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] defaultOctave = new int[10] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220 };
            int[] UsingOctave = defaultOctave;
            bool octava = true;
            while (octava)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Escape: octava = false; break;
                    case ConsoleKey.F1:
                        UsingOctave = OctaveChanger(1, defaultOctave);
                        break;
                    case ConsoleKey.F2:
                        UsingOctave = OctaveChanger(2, defaultOctave);
                        break;
                    case ConsoleKey.F3:
                        UsingOctave = OctaveChanger(3, defaultOctave);
                        break;
                    case ConsoleKey.F4:
                        UsingOctave = OctaveChanger(4, defaultOctave);
                        break;
                    case ConsoleKey.F5:
                        UsingOctave = OctaveChanger(5, defaultOctave);
                        break;
                    case ConsoleKey.F6:
                        UsingOctave = OctaveChanger(6, defaultOctave);
                        break;
                    case ConsoleKey.Q:
                        noteOutput(UsingOctave[0], 200);
                        break;
                    case ConsoleKey.W:
                        noteOutput(UsingOctave[1], 200);
                        break;
                    case ConsoleKey.E:
                        noteOutput(UsingOctave[2], 200);
                        break;
                    case ConsoleKey.R:
                        noteOutput(UsingOctave[3], 200);
                        break;
                    case ConsoleKey.T:
                        noteOutput(UsingOctave[4], 200);
                        break;
                    case ConsoleKey.Y:
                        noteOutput(UsingOctave[5], 200);
                        break;
                    case ConsoleKey.U:
                        noteOutput(UsingOctave[6], 200);
                        break;
                    case ConsoleKey.I:
                        noteOutput(UsingOctave[7], 200);
                        break;
                    case ConsoleKey.O:
                        noteOutput(UsingOctave[8], 200);
                        break;
                    case ConsoleKey.P:
                        noteOutput(UsingOctave[9], 200);
                        break;
                }
            }
        }


        static int[] OctaveChanger(int FCount, int[] defaultOctave)
        {
            int[] deftwoOctave = new int[10];
            for (int i = 0; i < deftwoOctave.Length; i++)
            {
                deftwoOctave[i] = defaultOctave[i] * FCount;
            }
            return deftwoOctave;
        }


        static void noteOutput(int HZ, int duration)
        {
            Console.Beep(HZ, duration);
        }
    }
}