using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class Picture
    {
        public int PictureId { get; set; }
        public int MemberId { get; set; }
        public string PictureName { get; set; }
        public byte[] MemberFacialRecognition { get; set; }
        public byte[] MemberPicture { get; set; }
        public DateTime? TimeStamp { get; set; }

        public Member Member { get; set; }
    }
}
