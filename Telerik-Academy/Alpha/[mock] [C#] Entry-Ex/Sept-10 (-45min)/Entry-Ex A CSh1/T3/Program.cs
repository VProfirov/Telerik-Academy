using System;
using System.Collections.Generic;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfCars = int.Parse(Console.ReadLine());
            var carSpeeds = new List<int>();
            for (int i = 0; i < countOfCars; i++)
            {
                carSpeeds.Add(int.Parse(Console.ReadLine()));
            }

            var currentSumOfSpeeds = -1;
            var carLeaderSpeed = -1;
            var carCount = 0;
            if (countOfCars > 0)
            {
                carLeaderSpeed = carSpeeds[0];
                currentSumOfSpeeds = carSpeeds[0];
                carCount += 1;
            }//else break;/return;
            var totalSpeedsOfGroupList = new List<int>();
            var totalCarCountOfGroupList = new List<int>();
            for (int currentCar = 1; currentCar < countOfCars; currentCar++)
            {
                if (currentCar + 1 >= countOfCars)
                {
                    if (carSpeeds[currentCar] <= carLeaderSpeed)
                    {
                        totalSpeedsOfGroupList.Add(currentSumOfSpeeds);
                        totalCarCountOfGroupList.Add(carCount);
                        //registering the last car even that it doesn
                        totalSpeedsOfGroupList.Add(carSpeeds[currentCar]);
                        totalCarCountOfGroupList.Add(1);
                        break;
                    }
                    currentSumOfSpeeds += carSpeeds[currentCar];
                    carCount += 1;
                    totalSpeedsOfGroupList.Add(currentSumOfSpeeds);
                    totalCarCountOfGroupList.Add(carCount);
                    break;
                }

                if (carSpeeds[currentCar] <= carLeaderSpeed)
                {
                    totalSpeedsOfGroupList.Add(currentSumOfSpeeds);
                    totalCarCountOfGroupList.Add(carCount);
                    currentSumOfSpeeds = carSpeeds[currentCar];
                    carLeaderSpeed = carSpeeds[currentCar];
                    carCount = 1;
                }
                else
                {
                    currentSumOfSpeeds += carSpeeds[currentCar];
                    carCount += 1;
                }
            }

            var maxCarsCount = -1;
            var maxCarsIndex = -1;
            var resultSpeed = 0;
            for (int i = 0; i < totalCarCountOfGroupList.Count; i++)
            {
                if (maxCarsCount < totalCarCountOfGroupList[i])
                {
                    maxCarsCount = totalCarCountOfGroupList[i];
                    maxCarsIndex = i;
                }

                if (maxCarsCount == totalCarCountOfGroupList[i])
                {
                    resultSpeed = Math.Max(totalSpeedsOfGroupList[maxCarsIndex], totalSpeedsOfGroupList[i]);
                }

                bool lastCarGroup = (i + 1 >= totalCarCountOfGroupList.Count);
                if (lastCarGroup)
                {
                    resultSpeed = Math.Max(resultSpeed, totalSpeedsOfGroupList[maxCarsIndex]);
                }
            }

            Console.WriteLine(resultSpeed);
        }
    }
}
