using System.Collections.Generic;


namespace unit04_greed.Game.Casting
{
    public class Cast
    {
        private Dictionary<string, List<Actor>> actors = new Dictionary<string, List<Actor>>();

        public Cast()
        {
        }

        /// <param name="group">The group name.</param>
        /// <param name="actor">The actor to add.</param>
        public void AddActor(string group, Actor actor)
        {
            if (!actors.ContainsKey(group))
            {
                actors[group] = new List<Actor>();
            }

            if (!actors[group].Contains(actor))
            {
                actors[group].Add(actor);
            }
        }

        
        /// <param name="group">The group name.</param>
        /// <returns>The list of actors.</returns>
        public List<Actor> GetActors(string group)
        {
            List<Actor> results = new List<Actor>();
            if (actors.ContainsKey(group))
            {
                results.AddRange(actors[group]);
            }
            return results;
        }

        /// <returns>A list of all actors.</returns>
        public List<Actor> GetAllActors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in actors.Values)
            {
                results.AddRange(result);
            }
            return results;
        }

        /// <param name="group">The group name.</param>
        /// <returns>The first actor.</returns>
        public Actor GetFirstActor(string group)
        {
            Actor result = null;
            if (actors.ContainsKey(group))
            {
                if (actors[group].Count > 0)
                {
                    result = actors[group][0];
                }
            }
            return result;
        }

        /// <param name="group">The group name.</param>
        /// <param name="actor">The actor to remove.</param>
        public void RemoveActor(string group, Actor actor)
        {
            if (actors.ContainsKey(group))
            {
                actors[group].Remove(actor);
            }
        }

    }
}