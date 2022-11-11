using CargoOperatingSystem.Shared.Domain;
using System;
using System.Collections.Generic;

namespace CargoOperatingSystem.Client.Static
{
    public static class ChwCalculator
    {
		
		public static double CalculateVolume(IList<Dimmension> Dimensions)
		{
			double calculationOfVolume = 0;

			if (Dimensions.Count > 0)
			{
				foreach (var dimension in Dimensions)
				{
					double calculatingVolPieces01 = ((dimension.Length * dimension.Width * dimension.Height * dimension.Pieces / 6000) / 166.7);
					calculationOfVolume += calculatingVolPieces01;
				}
			}

			return Math.Round(calculationOfVolume, 2);

		}

		public static double CalculateVolume(IList<AgentSubmitDim> Dimensions)
		{
			double calculationOfVolume = 0;

			if (Dimensions.Count > 0)
			{
				foreach (var dimension in Dimensions)
				{
					double calculatingVolPieces01 = ((dimension.Length * dimension.Width * dimension.Height * dimension.Pieces / 6000) / 166.7);
					calculationOfVolume += calculatingVolPieces01;
				}
			}

			return Math.Round(calculationOfVolume, 2);

		}

		public static double CalculateChW(IList<Dimmension> Dimensions, double GrossWeight)
		{

			double calculationOfChw = 0;

			double resultOfChw = 0;

			if (Dimensions.Count > 0)
			{
				foreach (var dimension in Dimensions)
				{
					double calculatingChwPieces01 = (dimension.Length * dimension.Width * dimension.Height * dimension.Pieces / 6000);

					calculationOfChw += calculatingChwPieces01;

				}

				resultOfChw = (Math.Ceiling((calculationOfChw*2))) / 2;

				if (resultOfChw < GrossWeight)
				{
					resultOfChw = GrossWeight;
				}
			}

			return resultOfChw;
		}

		public static double CalculateChW(IList<AgentSubmitDim> Dimensions, double GrossWeight)
		{

			double calculationOfChw = 0;

			double resultOfChw = 0;

			if (Dimensions.Count > 0)
			{
				foreach (var dimension in Dimensions)
				{
					double calculatingChwPieces01 = (dimension.Length * dimension.Width * dimension.Height * dimension.Pieces / 6000);

					calculationOfChw += calculatingChwPieces01;

				}

				resultOfChw = (Math.Ceiling((calculationOfChw * 2))) / 2;

				if (resultOfChw < GrossWeight)
				{
					resultOfChw = GrossWeight;
				}
			}

			return resultOfChw;
		}


	}
}
