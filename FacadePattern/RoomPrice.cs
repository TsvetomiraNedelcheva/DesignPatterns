namespace FacadeDesignPattern
{
    public class RoomPrice
    {
        private Room singleRoom;
        private Room doubleRoom;
        private Room tripleRoom;

        public RoomPrice()
        {
            singleRoom = new SingleRoom();
            doubleRoom = new DoubleRoom();
            tripleRoom = new TripleRoom();
        }

        public void Single()
        {
            singleRoom.getPrice();
        }

        public void Double()
        {
            doubleRoom.getPrice();
        }

        public void Triple()
        {
            tripleRoom.getPrice();
        }
    }
}
