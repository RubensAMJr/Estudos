using System;
using System.Collections.Generic;
using CursoDesignPatterns2.Cap2;

namespace CursoDesignPatterns2
{
    public class Piano
    {
        public void Toca(IList<INota> doReMiFa)
        {
            
                foreach (INota nota in doReMiFa)
                {
                    Console.Beep(nota.Frequencia, 300);
                }

            
        }
    }
}