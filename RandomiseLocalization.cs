using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace I2.Loc
{
    public static class RandomiseLocalization
    {
        public static void SetRandomTerm(this Localize localize, string[] terms)
        {
            if (terms.Length > 0) {
                localize.SetTerm(terms[Random.Range(0, terms.Length)]);
            }
        }

        public static void SetRandomAudio(this AudioSource source, string prefix) {
            var localize = source.GetComponent<Localize>();
            if (localize == null) {
                localize = source.gameObject.AddComponent<Localize>();
            }
            localize.SetRandomTerm(prefix);
        }

        public static void SetRandomTerm(this Localize localize, string prefix) {
            var allTerms = LocalizationManager.GetTermsList();
            var matchedTerms = new List<string>();
            foreach (var term in allTerms) {
                if (term.StartsWith(prefix)) {
                    matchedTerms.Add(term);
                }
            }
            if (matchedTerms.Count > 0) {
                localize.SetTerm(matchedTerms[Random.Range(0, matchedTerms.Count)]);
            }
        }
    }
}