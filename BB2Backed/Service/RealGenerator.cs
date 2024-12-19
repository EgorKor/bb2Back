using CreatingLevel;

namespace BB2Backed.Service
{
    public class RealGenerator : IContentGeneratorService
    {
        public LevelGenerator LevelGenerator { get; set; }
        const int PATTERN = 100;
        const int INEQUATION = 101;
        const int EQUATION = 102;

        public RealGenerator(LevelGenerator levelGenerator) {
            LevelGenerator = levelGenerator; 
        }
 
        public EquationDto GenerateEquation()
        {
            Puzzle equationPuzzle = LevelGenerator.CreatingLevel(EQUATION);
            Equation equation = (Equation)equationPuzzle.ClassWithPuzzle;
            return new EquationDto()
            {
                Equation = equation.equationString,
                Var = equation.targetVariable,
                Answer = equation.answer,
                Hint = equation.hint
            };
        }

        public InequalityDto GenerateInquality()
        {
            Puzzle inequalityPuzzle = LevelGenerator.CreatingLevel(INEQUATION);
            Inequality inequality = (Inequality)inequalityPuzzle.ClassWithPuzzle;
            return new InequalityDto()
            {
                Answer = inequality.Answer,
                Hint = inequality.Hint,
                Scales = inequality.Scales.ConvertAll(
                    el => new Scale()
                    {
                        LeftSide = el.LeftSide,
                        RightSide = el.RightSide,
                        State = el.State
                    })
            };
        }

        public PatternDto GeneratePattern()
        {
            Puzzle patternPuzzle = LevelGenerator.CreatingLevel(PATTERN);
            Pattern pattern = (Pattern)patternPuzzle.ClassWithPuzzle;
            return new PatternDto()
            {
                Pattern = pattern.pattern,
                Answer = pattern.answer,
                Hint = pattern.hint
            }; 
        }
    }
}
