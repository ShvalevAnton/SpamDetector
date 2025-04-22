using System.Diagnostics;

namespace SpamDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                //Content = @"Dear Lucky Winner, Congratulations! You have been selected as the winner of our international lottery. 
                //            You've won $1,000,000! To claim your prize, please reply with your full name, address, phone number and bank details."
                Content = @"Hi team, Just a reminder that we have our weekly project status meeting tomorrow at 10 AM in Conference Room B. Please bring your status reports and be prepared to discuss the timeline updates. Thanks, Sarah",
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            Console.WriteLine(result.PredictedLabel);

            //Load sample data
            //var sampleData1 = new SentimentAnalysis.ModelInput()
            //{
            //    SentimentText = @"== OK! ==  IM GOING TO VANDALIZE WILD ONES WIKI THEN!!!",
            //};

            ////Load model and predict output
            //var result1 = SentimentAnalysis.Predict(sampleData);

        }
    }
}
