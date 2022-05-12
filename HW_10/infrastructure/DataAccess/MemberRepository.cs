namespace HW_10.Models
{
    public class MemberRepository
    {
        private static List<Member> memberList = new List<Member>();
        public void Addmember(Member item)
        {
            item.ID = 1;
            var x = memberList.OrderByDescending(x => x.ID).FirstOrDefault();
            if (x != null)
                item.ID = x.ID + 1;
            memberList.Add(item);

        }
        public Member GetMemberdatail(int memberid)
        {
            return memberList.Where(x => x.ID == memberid).FirstOrDefault();
        }
        public void DelteMember(Member item)
        {
            memberList.Remove(item);
        }
        public void EditMember(Member item)
        {
            var _Member = GetMemberdatail(item.ID);
            _Member.Name = item.Name;
            _Member.Family = item.Family;
            _Member.Date_sabt = item.Date_sabt;
            _Member.Date_birthday = item.Date_birthday;
            _Member.Codemeli = item.Codemeli;
            _Member.Typemember = item.Typemember;
            _Member.Tel = item.Tel;
            _Member.Gender = item.Gender;
        }

        public List<Member> search(string N, string F)
        {
            return memberList.Where(x => x.Name == N || x.Family == F).ToList();
        }
        public List<Member> GetAllMember()
        {
            return memberList;
        }
    }

    
}

