using System.Collections.Generic;

namespace CreationalPattern.FactoryMethod
{
    /// <summary>
    /// The creator class
    /// </summary>
    abstract class Document
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Document"/> class. Invokes the factory method.
        /// </summary>
        public Document()
        {
            CreateDocument();
        }

        public IEnumerable<Page> Pages { get; protected set; }

        /// <summary>
        /// Creates the document. The factory method.
        /// </summary>
        public abstract void CreateDocument();

        /// <summary>
        /// Converts to string. Display document name
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance name.
        /// </returns>
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    /// <summary>
    /// Concrete Class
    /// </summary>
    /// <seealso cref="CreationalPattern.FactoryMethod.Document" />
    class Resume : Document
    {
        /// <summary>
        /// Creates the document. The implementation of factory method.
        /// </summary>
        public override void CreateDocument()
        {
            Pages = new List<Page> { new SkillPage(), new EducationPage(), new ExperiencePage() };
        }
    }

    /// <summary>
    /// Concrete Class
    /// </summary>
    /// <seealso cref="CreationalPattern.FactoryMethod.Document" />
    class Report : Document
    {
        /// <summary>
        /// Creates the document. The implementation of factory method.
        /// </summary>
        public override void CreateDocument()
        {
            Pages = new List<Page> { new IntroductionPage(), new ResultPage(), new ConclusionPage(), new SummaryPage(), new BibliographyPage() };
        }
    }

    /// <summary>
    /// The product class
    /// </summary>
    class Page
    {
        /// <summary>
        /// Converts to string. Display page name
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance name.
        /// </returns>
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    // Concreate Product classes
    class SkillPage : Page { }
    class EducationPage : Page { }
    class ExperiencePage : Page { }
    class IntroductionPage : Page { }
    class ResultPage : Page { }
    class ConclusionPage : Page { }
    class SummaryPage : Page { }
    class BibliographyPage : Page { }

}
