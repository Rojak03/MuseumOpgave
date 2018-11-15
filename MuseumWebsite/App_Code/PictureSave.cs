using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Web;

/// <summary>
/// Summary description for PictureSave
/// </summary>
public class PictureSave
{

    protected static string AdjustFileName(string FilNavn)
    {
        FilNavn = FilNavn.ToLower();
        FilNavn = FilNavn.Replace(" ", "_");
        FilNavn = FilNavn.Replace("æ", "ae");
        FilNavn = FilNavn.Replace("ø", "oe");
        FilNavn = FilNavn.Replace("å", "aa");
        return FilNavn;
    }


    /// <summary>
    /// Simpel image-saver - gemmer uden at skalere eller ændre filnavn (bortset fra æøå)
    /// </summary>
    /// <param name="FU">Fileuploader - postedfile</param>
    /// <param name="GemHer">Sti hvor image skal gemmes fx "img/"</param>
    /// <returns>Imagenavn - æøå erstattet med ae oe aa</returns>
    public static string SavePicture(HttpPostedFile FU, string GemHer)
    {
        string ImageNavn;
        try
        {
            ImageNavn = Path.GetFileName(FU.FileName);
            ImageNavn = AdjustFileName(ImageNavn); // erstat æøå mv.
            FU.SaveAs(Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, GemHer) + ImageNavn);
        }
        catch (Exception ex)
        {
            //return ex.ToString();
            return "Noget gik galt";
        }
        return ImageNavn;
    }



    /// <summary>
    /// Gemmer et billede optimeret til web og i en ønsket/medsendt width (højden skaleres ift bredden). Tilføjer et timestamp eller guid til filnavn for at undgå dubletter/overskrivning
    /// </summary>
    /// <param name="FU">Fileuploader - postedfile</param>
    /// <param name="GemHer">Sti hvor image skal gemmes fx "img/"</param>
    /// <param name="Width">Ønsket bredde på image</param>
    /// <returns>Imagenavn - æøå erstattet med ae oe aa samt tilføjet et timestamp eller guid (for at undgå dubletter/overskrivning)</returns>
    public static string SavePicture(HttpPostedFile FU, string GemHer, int Width)
    {

        // Undgå images med samme navn - tilføj GUID 
        //string NytFilNavn = Path.GetFileNameWithoutExtension(FU.FileName) + Guid.NewGuid().ToString() + Path.GetExtension(FU.FileName);

        // ELLER ... undgå images med samme navn - tilføj TIMESTAMP ... lav evt. om til ("_yyMMddHHmmssffff")
        string NytImageNavn = Path.GetFileNameWithoutExtension(FU.FileName) + DateTime.Now.ToString("_yyMMddHHmmss");
        return PictureSave.SavePicture(FU, GemHer, Width, NytImageNavn);
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="FU">Fileuploader - postedfile</param>
    /// <param name="GemHer">Sti hvor image skal gemmes fx "img/"</param>
    /// <param name="Width"></param>
    /// <param name="ImageNavn">Ønsket navn på image UDEN extension (.jpg, .gif, .png)</param>
    /// <returns>Imagenavn - evt. æøå erstattet med ae oe aa</returns>
    public static string SavePicture(HttpPostedFile FU, string GemHer, int Width, string ImageNavn)
    {
        ImageNavn = AdjustFileName(ImageNavn);
        ImageNavn = ImageNavn + Path.GetExtension(FU.FileName);
        string extension = Path.GetExtension(FU.FileName).ToLower(); //.jpg

        if (extension == ".jpg" || extension == ".jpeg" || extension == ".gif" || extension == ".png")
        {
            try
            {
                String TempImage;
                String NytImage;

                // TEMPIMAGE - arbejdsfilen - prefikses med _temp_, gemmes i mappen hvor det færdige billede skal gemmes, og bliver gjort til streamin for nye billede
                TempImage = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, GemHer) + "_temp_" + ImageNavn;
                FU.SaveAs(TempImage);

                StreamReader StreamIn = new StreamReader(TempImage);

                NytImage = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, GemHer) + ImageNavn;
                StreamWriter StreamOut = new StreamWriter(NytImage);
                ResizeImage(Width, StreamIn.BaseStream, StreamOut.BaseStream);
                // LUK streams og slet TEMP-billede
                StreamOut.Close();
                StreamIn.Close();
                File.Delete(TempImage);
            }
            catch (Exception)
            {
                throw;
            }
        }
        else
        {
            ImageNavn = "Noget gik galt - image er muligvis ikke af typen jpg, jpeg, gif eller png!";
        }
        return ImageNavn;
    }



    protected static void ResizeImage(int width, Stream fromStream, Stream toStream)
    {
        //Propertionelt AspectRation 
        float originalAspectRatio = (float)Image.FromStream(fromStream).Width / (float)Image.FromStream(fromStream).Height;
        float newWidth, newHeight;
        var image = Image.FromStream(fromStream);

        //Hvis det billede der uploades er mindre end "resize" - bliver det ikke scaleret op.
        //Dette er for ikke at "pixelere" billederne
        if (width < (float)Image.FromStream(fromStream).Width)
        {
            newWidth = width;
            newHeight = (float)width / (float)originalAspectRatio;
        }
        else
        {
            newWidth = (float)Image.FromStream(fromStream).Width;
            newHeight = (float)Image.FromStream(fromStream).Height;
        }

        Debug.Write("ASPECT: = " + newHeight);
        var thumpnailBitmap = new Bitmap((int)newWidth, (int)newHeight);
        var thumpnailGraph = Graphics.FromImage(thumpnailBitmap);
        thumpnailGraph.CompositingQuality = CompositingQuality.HighQuality;
        thumpnailGraph.SmoothingMode = SmoothingMode.HighQuality;
        thumpnailGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
        var imageRectangle = new Rectangle(0, 0, (int)newWidth, (int)newHeight);
        thumpnailGraph.DrawImage(image, imageRectangle);
        thumpnailBitmap.Save(toStream, image.RawFormat);
        thumpnailGraph.Dispose();
        thumpnailBitmap.Dispose();
        image.Dispose();
    }

}