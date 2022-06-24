using System.Collections.Generic;
using System.IO;
using System;

namespace unit04_greed.Game.Casting
{
    
        public class Artifact:Actor{
            private int score = 0;

            public Artifact(){

            }
       
        /// <returns>The message as a string.</returns>
            public int GetScore(){
                
                return score;

            }
        

   
        /// <param name="message">The given message.</param>
            public void SetScore(int score){
                this.score = score;

            }
        }
}