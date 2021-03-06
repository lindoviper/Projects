namespace CQRSKata
{
    public class MoveCommand : ICommand
    {
        private Direction _direction;

        public MoveCommand(Direction direction)
        {
            _direction = direction;
        }

        public Direction Direction
        {
            set { _direction = value; }
            get { return _direction; }
        }
    }
}