using System;
using System.Drawing;

namespace Model
{
	public interface iPictureSerializer
	{
		Bitmap TurnStringToImage(string bitmampString);
		
		string UploadImageAsString();
		
		bool ValidFile(string filename, long limitInBytes, int limitWidth, int limitHeight);
		
		bool ValidFile(string filename, long limitInBytes);
	}
}
