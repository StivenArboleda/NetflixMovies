using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies.model
{
    class ClassML
    { 
        // 1 entreno el metodo 
        // probabilidad 85.%  avengers1
        public void excuteML(string method) {

            var mlContext = new MLContext();

            if (method == "entrenar")
            {
                var trainerData = mlContext.Data.LoadFromTextFile<TreeML>("..\\..\\Data\\netflix_titles.csv");

                var transformation = mlContext.Transforms.Text.FeaturizeText(outputColumnName: "Generos", inputColumnName: nameof(TreeML.Clasification));

                var classif = mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName: nameof(TreeML.Clasification), featureColumnName: "Generos");

                var transformation2 = mlContext.Transforms.Text.FeaturizeText(outputColumnName: "Año de lanzamiento", inputColumnName: nameof(TreeML.ReleaseYear));

                var releaseY = mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName: nameof(TreeML.ReleaseYear), featureColumnName: "Año de lanzamiento");

                var transformation3 = mlContext.Transforms.Text.FeaturizeText(outputColumnName: "Reparto", inputColumnName: nameof(TreeML.Cast));

                var cas = mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName: nameof(TreeML.Cast), featureColumnName: "Reparto");

                //var pipeline = transformation.Append(classif).Append();
            }
            else {
            
            
            }
        }
    }
}
