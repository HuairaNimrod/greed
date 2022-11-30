namespace Greed.Game.Casting
{
    /// <summary>
    /// <para>Something you collect like a rock or a gem.</para>
    /// <para>The responsibility of Collectable is to keep track of points.
    /// </para>
    /// </summary>
    public class Collectable : Actor
    {
        private int _points;
        
        public Collectable()
        {
        }

        public int GetPoints()
        {
            return _points;
        }

        public void SetPoints(int points)
        {
            _points = points;
        }
    }
}