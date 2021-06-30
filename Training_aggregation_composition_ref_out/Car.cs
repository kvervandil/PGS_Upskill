namespace Training_aggregation_composition_ref_out
{
    internal class Car
    {
        private Engine engine;
        private Wheel wheelLeftFront;
        private Wheel wheelLeftRear;
        private Wheel wheelRightFront;
        private Wheel wheelRightRear;

        public Car(Engine engine, Wheel wheelLeftFront, Wheel wheelLeftRear, Wheel wheelRightFront, Wheel wheelRightRear)
        {
            this.engine = engine;
            this.wheelLeftFront = wheelLeftFront;
            this.wheelLeftRear = wheelLeftRear;
            this.wheelRightFront = wheelRightFront;
            this.wheelRightRear = wheelRightRear;
        }
    }
}