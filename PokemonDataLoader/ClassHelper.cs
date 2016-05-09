using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonDataLoader
{
    public static class ClassHelper
    {
        private struct Class
        {
            public string Name { get; set; }
            public List<Member> Members { get; set; }

            public string Print()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(Name);
                sb.AppendLine("\t{");
                foreach (Member m in Members)
                {
                    sb.Append("\t\t");
                    sb.AppendLine(m.JsonProperty);
                    sb.Append("\t\t");
                    sb.AppendFormat("{0} {1} {2} {{ get; set; }}",
                        m.AccessModifier, m.ReturnType, m.MemberName);
                    sb.AppendLine();
                }
                sb.AppendLine("\t}");

                return sb.ToString();
            }
        }

        private struct Member
        {
            public string AccessModifier { get; set; }
            public string ReturnType { get; set; }
            public string MemberName { get; set; }
            public string JsonProperty { get; set; }
        }

        public static string Merge(string class1, string class2)
        {
            string class1Name = class1.Substring(0, class1.IndexOf("\r\n"));
            Class c1 = ConvertToClass(class1, class1Name);

            string class2Name = class2.Substring(0, class2.IndexOf("\r\n"));
            Class c2 = ConvertToClass(class2, class2Name);
            
            Class c3 = CombineMembers(c1, c2);
            
            return c3.Print();
        }

        private static Class ConvertToClass(string classString, string className)
        {
            Class c = new Class
            {
                Name = className,
                Members = new List<Member>()
            };

            string[] lines = classString.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            IEnumerator enumerator = lines.GetEnumerator();
            while (enumerator.MoveNext())
            {
                string line = (string) enumerator.Current;

                if (line.Contains("{") || line.Contains("}") || line.StartsWith(className))
                    continue;

                // Check for JsonProperties
                if (line.Contains("["))
                {
                    Member m = new Member();
                    m.JsonProperty = line.Trim();
                    // Data Member always follows the JsonProperty
                    enumerator.MoveNext();
                    line = (string) enumerator.Current;
                    string[] members = line.Trim().Split(' ');
                    m.AccessModifier = members[0];
                    m.ReturnType = members[1];
                    m.MemberName = members[2];
                    c.Members.Add(m);
                }
            }

            return c;
        }

        private static Class CombineMembers(Class c1, Class c2)
        {
            Class combined = new Class
            {
                Name = c1.Name,
                Members = new List<Member>()
            };

            foreach (Member m1 in c1.Members)
            {
                if (!combined.Members.Any(m => m.JsonProperty == m1.JsonProperty))
                    combined.Members.Add(m1);
                else
                {
                    Member member = combined.Members
                                    .Where(m => m.JsonProperty == m1.JsonProperty)
                                    .First();
                    member.ReturnType = m1.ReturnType == "object" ? member.ReturnType : m1.ReturnType;
                }
            }

            foreach (Member m2 in c2.Members)
            {
                if (!combined.Members.Any(m => m.JsonProperty == m2.JsonProperty))
                    combined.Members.Add(m2);
                else
                {
                    Member member = combined.Members
                                    .Where(m => m.JsonProperty == m2.JsonProperty)
                                    .First();
                    member.ReturnType = m2.ReturnType == "object" ? member.ReturnType : m2.ReturnType;
                }
            }

            return combined;
        }
    }
}
