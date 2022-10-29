using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.Models
{
    public class TranslationViewModel
    {
        /// <summary>
        /// Gets or sets the translation master identifier.
        /// </summary>
        /// <value>
        /// The translation master identifier.
        /// </value>
     
        public int LanguageId { get; set; }

        /// <summary>
        /// Gets or sets the translation master identifier.
        /// </summary>
        /// <value>
        /// The translation master identifier.
        /// </value>
        public int TranslationMasterId { get; set; }

        /// <summary>
        /// Gets or sets the translation type identifier.
        /// </summary>
        /// <value>
        /// The translation type identifier.
        /// </value>
        public int TranslationTypeId { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
       
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the translation language identifier.
        /// </summary>
        /// <value>
        /// The translation language identifier.
        /// </value>
        public int? TranslationLanguageId { get; set; }

        /// <summary>
        /// Gets or sets the modified on.
        /// </summary>
        /// <value>
        /// The modified on.
        /// </value>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [NotMapped]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
     //   public virtual LanguageModel Language { get; set; }
    }
}
