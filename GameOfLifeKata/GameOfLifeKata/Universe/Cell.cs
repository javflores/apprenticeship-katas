namespace GameOfLifeKata.Universe
{
    public class Cell
    {
        private bool _isAlive = false;

        public Cell()
        {
            
        }

        public Cell(bool isAlive)
        {
            _isAlive = isAlive;
        }

        public virtual Cell ToNextGeneration()
        {
            throw new System.NotImplementedException();
        }
    }
}