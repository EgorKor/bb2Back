using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BB2Backed
{
    [ApiController]
    public class GenerationController
    {
        private IContentGeneratorService _generator;

        public GenerationController(IContentGeneratorService generator)
        {
            _generator = generator;
        }

        [HttpGet("/generate/inequality")]
        public InequalityDto GenerateInequality()
        {
            return _generator.GenerateInquality();
        }

        [HttpGet("/generate/equation")]
        public EquationDto GenerateEquation()
        {
            return _generator.GenerateEquation();
        }

        [HttpGet("/generate/pattern")]
        public PatternDto GeneratePattern()
        {
            return _generator.GeneratePattern();
        } 
        

    }
}
