
namespace BB2Backed
{
    public interface IContentGeneratorService
    {
        public EquationDto GenerateEquation();

        public InequalityDto GenerateInquality();

        public PatternDto GeneratePattern();
    }
}
