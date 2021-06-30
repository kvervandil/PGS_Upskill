namespace Training_aggregation_composition_ref_out
{
    public class Person
    {
        private Arm _rightArm;
        private Arm _leftArm;
        private Leg _rightLeg;
        private Leg _leftLeg;

        public Person()
        {
            _rightArm = new Arm();
            _leftArm = new Arm();
            _rightLeg = new Leg();
            _leftLeg = new Leg();

        }
    }
}