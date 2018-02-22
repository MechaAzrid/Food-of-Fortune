using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

namespace Health
{
    public enum EHealthStatus
    {
        //Testing Enum's
        //HealthExcellent,
        //HealthGreat,
        //HealthGood,
        //HealthOkay,
        //HealthBad,
        //HealthWorse,
        //Unhealthy,

        //Original Enum's
        HealthyMaxResponse,
        HealthyMidResponse,
        HealthyLowResponse,
        NeutralResponse,
        UnhealthyLowResponse,
        UnhealthyMidResponse,
        UnhealthyMaxResponse
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
                return EHealthStatus.HealthyMaxResponse;
            }
                else if (FoodValue >= 5)
                {
                    return EHealthStatus.HealthyMidResponse;
                }
                    else if (FoodValue > 0)
                    {
                        return EHealthStatus.HealthyLowResponse;
                    }
                        else if (FoodValue == 0)
                        {
                            return EHealthStatus.NeutralResponse;
                        }
                            else if (FoodValue >= -5)
                            {
                                return EHealthStatus.UnhealthyLowResponse;
                            }
                                else if (FoodValue >= -10)
                                {
                                    return EHealthStatus.UnhealthyMidResponse;
                                }
                                    else
                                    {
                                        return EHealthStatus.UnhealthyMaxResponse;
                                    }
            }
            ///This maps an EHealthStatus to a list of responses. You can have as many responses in here as you want
            ///I'm using brace initializer syntax to populate the dictionary - you'd want to add a new thing for each value in your enum
            public Dictionary<EHealthStatus, List<string>> Responses = new Dictionary<EHealthStatus, List<string>>()
        { ///These braces are for the dictionary
            {/// these braces are for a EHealthStatus, List<string> pair
                EHealthStatus.UnhealthyMaxResponse, new List<string>()
                    { ///these braces initialize the List<string>
                        "I went to the doctor yesterday, they broke the news to me. Seems I have Type 2 Diabetes.",
                        "I've found it hard to exercise lately - I just have this feeling of lethargy.",
                        "I've been finding it really difficult to get out of bed, sometimes I wonder if life has much meaning."
                    }
            },
            {
                EHealthStatus.UnhealthyMidResponse, new List<string>()
                    {
                        "I just find myself always coming back for more.",
                        "I have so much work to do, but just haven't been able to concentrate on my work.",
                        "I've been having a lot of trouble sleeping lately, might go see a doctor about it soon."
                    }
            },

            {
                EHealthStatus.UnhealthyLowResponse, new List<string>()
                    {
                        "Wow, the food here is better than I expected. Cheap and fast as well.",
                        "The food is cheap here, good as a fast meal.",
                        "The food here last time was so good, I have to have it again."
                    }
            },

            {
                EHealthStatus.NeutralResponse, new List<string>()
                    {
                        "Hey! You have some interesting foods here.",
                        "Can't wait to try out your food! Looks delicious!",
                        "Been wanting to eat here all week! You have some tasty items on your menu!"
                    }
            },

            {
                EHealthStatus.HealthyLowResponse, new List<string>()
                    {
                        "Wow, the food here is better than I expected for its price.",
                        "The food here last time was so good, I have to have it again.",
                        "Your food is a bit pricey, but worth it!"
                    }
            },

            {
                EHealthStatus.HealthyMidResponse, new List<string>()
                    {
                        "I just find myself always coming back for more.",
                        "Naps are great aren't they? They make you feel so great and revitalised for the day!",
                        "I'm so far ahead on all my responsibilities and work, it's so much easier to focus."
                    }
            },

            {
                EHealthStatus.HealthyMaxResponse, new List<string>()
                    {
                        "I've been feeling more energised lately, I hope it has something to do with your food cart.",
                        "I've been going to the gym every morning now, much more often than I used to.",
                        "I went to the doctor yesterday, my health is at its peak."
                    }
            }
        };
    }
}