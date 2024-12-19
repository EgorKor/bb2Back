namespace BB2Backed.Service
{
    public class MockContentGeneratorService : IContentGeneratorService
    {
        public EquationDto GenerateEquation()
        {
            return new EquationDto()
            {
                Var = "x",
                Equation = "x + 10 = 20",
                Answer="10",
                Hint="hint",
            };

        }

        public InequalityDto GenerateInquality()
        {
            return new InequalityDto()
            {
                Answer = "1",
                Hint = "2",
                Scales = new List<Scale>()
                {
                    new Scale()
                    {
                        LeftSide = new List<string>()
                        {
                            "1","5"
                        },
                        RightSide = new List<string>()
                        {
                            "5","9"
                        },
                        State = 0
                    }
                }
            };
        }

        public PatternDto GeneratePattern()
        {
            return new PatternDto()
            {
                Pattern = "1 3 ... 7",
                Answer = "5",
                Hint = "hint"
            };
        }
    }
}
