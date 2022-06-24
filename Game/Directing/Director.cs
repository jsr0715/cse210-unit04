using System.Collections.Generic;
using unit04_greed.Game.Casting;
using unit04_greed.Game.Services;
using System;
using System.IO;
using System.Linq;
using unit04_greed.Game.Directing;



namespace unit04_greed.Game.Directing
{
   
    public class Director
    {
        public int score = 0;
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;

        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        { 
            videoService.OpenWindow();
            while (videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            videoService.CloseWindow();
        }


        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            List<Actor> artifacts = cast.GetActors("artifacts");
            foreach (Actor actor in artifacts){
                Point artifactvelocity = keyboardService.MoveArtifact();
                actor.SetVelocity(artifactvelocity);
                int maxX = videoService.GetWidth();
                int maxY = videoService.GetHeight();
                actor.MoveNext(maxX, maxY);
            }
            Actor robot = cast.GetFirstActor("robot");
            Point velocity = keyboardService.GetDirection();
            robot.SetVelocity(velocity); 
        }

        
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {

            Actor banner = cast.GetFirstActor("banner");
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> artifacts = cast.GetActors("artifacts");

            banner.SetText($"Score: {score.ToString()}");
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            robot.MoveNext(maxX, maxY);

            Random random = new Random();
            foreach (Actor actor in artifacts)
            {
                
                if (robot.GetPosition().Equals(actor.GetPosition()))
                {
                    Artifact artifact = (Artifact) actor;
                    score += artifact.GetScore();
                    banner.SetText($"Score: {score.ToString()}");

                    int x = random.Next(1, 60);
                    int y = 0;
                    Point position = new Point(x, y);
                    position = position.Scale(15);

                    artifact.SetPosition(position);
                }
            } 
        }

        
        /// <param name="cast">The given cast.</param>
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
        }

    }
}