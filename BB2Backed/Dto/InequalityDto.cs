namespace BB2Backed
{
    public class InequalityDto
    {
        public List<Scale> Scales { get; set; }
        public string Answer { get; set; }
        public string Hint { get; set; }
    }

    public class Scale
    {
        public List<string> LeftSide { get; set; }
        public List<string> RightSide { get; set; }
        public int State { get; set; }
    }
}
