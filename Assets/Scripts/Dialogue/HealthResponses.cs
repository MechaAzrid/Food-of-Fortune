using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

namespace Health
{

    public enum EHealthStatus
    {
        HealthExcellent,
        HealthGreat,
        HealthGood,
        HealthOkay,
        HealthBad,
        HealthWorse,
        Unhealthy
    }


    public class HealthResponses : MonoBehaviour
    {

        public string GetHealthResponse(int FoodValue)
        {
            //get the right health status for the food value, then look that up in the dictionary to get the list of valid responses
            List<string> ValidResponses = Responses[GetHealthStatusForFoodValue(FoodValue)];
                //Get a random number between 0 and the number of responses in the list + 1 (Random number generators have an exclusive upper bound)
                //use that random number as an index into the list and return the resulting string.
                return ValidResponses[new System.Random().Next(0, ValidResponses.Count)];
        }


        ///This function maps a numeric FoodValue to an EHealthStatus
        public EHealthStatus GetHealthStatusForFoodValue(int FoodValue)
        {
            if (FoodValue >= 10)
            {
                return EHealthStatus.HealthExcellent;
            }
            else if (FoodValue >= 5)
            {
                return EHealthStatus.HealthGreat;
            }
            else if (FoodValue > 0)
            {
                return EHealthStatus.HealthGood;
            }
            else if (FoodValue == 0)
            {
                return EHealthStatus.HealthOkay;
            }
            else if (FoodValue >= -5)
            {
                return EHealthStatus.HealthBad;
            }
            else if (FoodValue >= -10)
            {
                return EHealthStatus.HealthWorse;
            }
            else
            {
                return EHealthStatus.Unhealthy;
            }
        }
            ///This maps an EHealthStatus to a list of responses. You can have as many responses in here as you want
            ///I'm using brace initializer syntax to populate the dictionary - you'd want to add a new thing for each value in your enum
            public Dictionary<EHealthStatus, List<string>> Responses = new Dictionary<EHealthStatus, List<string>>()
        { ///These braces are for the dictionary
            {/// these braces are for a EHealthStatus, List<string> pair
                EHealthStatus.Unhealthy, new List<string>()
                    { ///these braces initialize the List<string>
                        "I went to the doctor yesterday, they broke the news to me. Seems I have Type 2 Diabetes.",
                        "I've found it hard to exercise lately - I just have this feeling of lethargy.",
                        "I've been finding it really difficult to get out of bed, sometimes I wonder if life has much meaning."
                    }
            },
            {
                EHealthStatus.HealthWorse, new List<string>()
                    {
                        "I just find myself always coming back for more.",
                        "I have so much work to do, but just haven't been able to concentrate on my work.",
                        "I've been having a lot of trouble sleeping lately, might go see a doctor about it soon."
                    }
            }
        };
    }
}