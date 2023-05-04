using System;
using System.Collections.Generic;
using System.IO;
using System.Media;

namespace Maya.Engine
{
    public class MayaSound : MayaEngine
    {
        public static void PlaySoundLoop(string soundfile)
        {
            if (string.IsNullOrEmpty(soundfile)) { return; }
            SoundPlayer mayaplay = new SoundPlayer(soundfile);
            try
            {
                mayaplay.SoundLocation = soundfile;
                mayaplay.LoadAsync();
                mayaplay.PlayLooping();
            }
            catch (FileNotFoundException) { return; }
            catch (DirectoryNotFoundException) { return; }
            catch (IOException) { return; }
            catch { return; }
            return;
        }
        public static void PlaySound(string soundfile)
        {
            if (string.IsNullOrEmpty(soundfile)) { return; }
            SoundPlayer mayaplay = new SoundPlayer(soundfile);
            try
            {
                mayaplay.SoundLocation = soundfile;
                mayaplay.LoadAsync();
                mayaplay.Play();
            }
            catch (FileNotFoundException) { return; }
            catch (DirectoryNotFoundException) { return; }
            catch (IOException) { return; }
            catch { return; }
            return;
        }
        public static void Beep(int frequency, int length)
        {
            bool test0 = int.TryParse(frequency.ToString(), out frequency);
            if (test0 == true)
            {
                bool test1 = int.TryParse(length.ToString(), out length);
                if (test1 == true)
                {
                    Console.Beep(frequency, length);
                }
                else { return; }
            }
            else { return; }
            return;
        }
        public static void BeepToneNote(string tone, int length)
        {
            bool test0 = int.TryParse(length.ToString(), out length);
            if (test0 == true)
            {
                if (string.IsNullOrEmpty(tone)) { return; }
                else
                {
                    GetTone(tone, length);
                }
            }
            else { return; }
            return;
        }
        static void GetTone(string tone, int length)
        {
            Dictionary<string, Action> tones = new Dictionary<string, Action>
            {
                { "'D" , () => Beep(37, length) },
                { "'Es" , () => Beep(39, length) },
                { "'E" , () => Beep(41, length) },
                { "'F" , () => Beep(43, length) },
                { "'Ges" , () => Beep(46, length) },
                { "'G" , () => Beep(49, length) },
                { "'As" , () => Beep(52, length) },
                { "'A" , () => Beep(55, length) },
                { "'B" , () => Beep(58, length) },
                { "'H" , () => Beep(62, length) },
                { "C" , () => Beep(65, length) },
                { "Des" , () => Beep(69, length) },
                { "D" , () => Beep(73, length) },
                { "Es" , () => Beep(78, length) },
                { "E" , () => Beep(82, length) },
                { "F" , () => Beep(87, length) },
                { "Ges" , () => Beep(92, length) },
                { "G" , () => Beep(98, length) },
                { "As" , () => Beep(103, length) },
                { "A" , () => Beep(110, length) },
                { "B" , () => Beep(116, length) },
                { "H" , () => Beep(123, length) },
                { "c" , () => Beep(130, length) },
                { "des" , () => Beep(138, length) },
                { "d" , () => Beep(146, length) },
                { "es" , () => Beep(155, length) },
                { "e" , () => Beep(164, length) },
                { "f" , () => Beep(174, length) },
                { "ges" , () => Beep(185, length) },
                { "g" , () => Beep(196, length) },
                { "as" , () => Beep(207, length) },
                { "a" , () => Beep(220, length) },
                { "b" , () => Beep(233, length) },
                { "h" , () => Beep(246, length) },
                { "c'" , () => Beep(261, length) },
                { "des'" , () => Beep(277, length) },
                { "d'" , () => Beep(293, length) },
                { "es'" , () => Beep(311, length) },
                { "e'" , () => Beep(329, length) },
                { "f'" , () => Beep(349, length) },
                { "ges'" , () => Beep(369, length) },
                { "g'" , () => Beep(392, length) },
                { "as'" , () => Beep(415, length) },
                { "a'" , () => Beep(440, length) },
                { "b'" , () => Beep(466, length) },
                { "h'" , () => Beep(493, length) },
                { "c''" , () => Beep(523, length) },
                { "des''" , () => Beep(554, length) },
                { "d''" , () => Beep(587, length) },
                { "es''" , () => Beep(622, length) },
                { "e''" , () => Beep(659, length) },
                { "f''" , () => Beep(698, length) },
                { "ges''" , () => Beep(739, length) },
                { "g''" , () => Beep(783, length) },
                { "as''" , () => Beep(830, length) },
                { "a''" , () => Beep(880, length) },
                { "b''" , () => Beep(932, length) },
                { "h''" , () => Beep(987, length) },
                { "c'''" , () => Beep(1056, length) },
                { "des'''" , () => Beep(1108, length) },
                { "d'''" , () => Beep(1174, length) },
                { "es'''" , () => Beep(1244, length) },
                { "e'''" , () => Beep(1318, length) },
                { "f'''" , () => Beep(1396, length) },
                { "ges'''" , () => Beep(1479, length) },
                { "g'''" , () => Beep(1567, length) },
                { "as'''" , () => Beep(1661, length) },
                { "a'''" , () => Beep(1760, length) },
                { "b'''" , () => Beep(1864, length) },
                { "h'''" , () => Beep(1975, length) },
                { "c''''" , () => Beep(2093, length) },
                { "des''''" , () => Beep(2217, length) },
                { "d''''" , () => Beep(2349, length) },
                { "es''''" , () => Beep(2489, length) },
                { "e''''" , () => Beep(2637, length) },
                { "f''''" , () => Beep(2793, length) },
                { "ges''''" , () => Beep(2959, length) },
                { "g''''" , () => Beep(3135, length) },
                { "as''''" , () => Beep(3322, length) },
                { "a''''" , () => Beep(3520, length) },
                { "b''''" , () => Beep(3729, length) },
                { "h''''" , () => Beep(3951, length) },
                { "c'''''" , () => Beep(4168, length) },

                { "1D" , () => Beep(37, length) },
                { "1ES" , () => Beep(39, length) },
                { "1E" , () => Beep(41, length) },
                { "1F" , () => Beep(43, length) },
                { "1GES" , () => Beep(46, length) },
                { "1G" , () => Beep(49, length) },
                { "1AS" , () => Beep(52, length) },
                { "1A" , () => Beep(55, length) },
                { "1B" , () => Beep(58, length) },
                { "1H" , () => Beep(62, length) },
                { "C0" , () => Beep(65, length) },
                { "DES" , () => Beep(69, length) },
                { "D0" , () => Beep(73, length) },
                { "ES" , () => Beep(78, length) },
                { "E0" , () => Beep(82, length) },
                { "F0" , () => Beep(87, length) },
                { "GES" , () => Beep(92, length) },
                { "G0" , () => Beep(98, length) },
                { "AS0" , () => Beep(103, length) },
                { "A0" , () => Beep(110, length) },
                { "B0" , () => Beep(116, length) },
                { "H0" , () => Beep(123, length) },
                { "0c" , () => Beep(130, length) },
                { "0des" , () => Beep(138, length) },
                { "0d" , () => Beep(146, length) },
                { "0es" , () => Beep(155, length) },
                { "0e" , () => Beep(164, length) },
                { "0f" , () => Beep(174, length) },
                { "0ges" , () => Beep(185, length) },
                { "0g" , () => Beep(196, length) },
                { "0as" , () => Beep(207, length) },
                { "0a" , () => Beep(220, length) },
                { "0b" , () => Beep(233, length) },
                { "0h" , () => Beep(246, length) },
                { "c1" , () => Beep(261, length) },
                { "des1" , () => Beep(277, length) },
                { "d1" , () => Beep(293, length) },
                { "es1" , () => Beep(311, length) },
                { "e1" , () => Beep(329, length) },
                { "f1" , () => Beep(349, length) },
                { "ges1" , () => Beep(369, length) },
                { "g1" , () => Beep(392, length) },
                { "as1" , () => Beep(415, length) },
                { "a1" , () => Beep(440, length) },
                { "b1" , () => Beep(466, length) },
                { "h1" , () => Beep(493, length) },
                { "c2" , () => Beep(523, length) },
                { "des2" , () => Beep(554, length) },
                { "d2" , () => Beep(587, length) },
                { "es2" , () => Beep(622, length) },
                { "e2" , () => Beep(659, length) },
                { "f2" , () => Beep(698, length) },
                { "ges2" , () => Beep(739, length) },
                { "g2" , () => Beep(783, length) },
                { "as2" , () => Beep(830, length) },
                { "a2" , () => Beep(880, length) },
                { "b2" , () => Beep(932, length) },
                { "h2" , () => Beep(987, length) },
                { "c3" , () => Beep(1056, length) },
                { "des3" , () => Beep(1108, length) },
                { "d3" , () => Beep(1174, length) },
                { "es3" , () => Beep(1244, length) },
                { "e3" , () => Beep(1318, length) },
                { "f3" , () => Beep(1396, length) },
                { "ges3" , () => Beep(1479, length) },
                { "g3" , () => Beep(1567, length) },
                { "as3" , () => Beep(1661, length) },
                { "a3" , () => Beep(1760, length) },
                { "b3" , () => Beep(1864, length) },
                { "h3" , () => Beep(1975, length) },
                { "c4" , () => Beep(2093, length) },
                { "des4" , () => Beep(2217, length) },
                { "d4" , () => Beep(2349, length) },
                { "es4" , () => Beep(2489, length) },
                { "e4" , () => Beep(2637, length) },
                { "f4" , () => Beep(2793, length) },
                { "ges4" , () => Beep(2959, length) },
                { "g4" , () => Beep(3135, length) },
                { "as4" , () => Beep(3322, length) },
                { "a4" , () => Beep(3520, length) },
                { "b4" , () => Beep(3729, length) },
                { "h4" , () => Beep(3951, length) },
                { "c5" , () => Beep(4168, length) },
            };

            if (tones.ContainsKey(tone))
            {
                tones[tone]();
            }
        }
    }
}
