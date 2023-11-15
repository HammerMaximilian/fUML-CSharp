using fuml.library.common;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.values;
using System.Text;
using UMLPrimitiveTypes;

namespace fuml.library.channel
{
    public class StandardInputChannelObject : TextInputChannelObject
    {
        StreamReader? reader = new(Console.OpenStandardInput());

        public StandardInputChannelObject()
        {
            types.Add(FoundationalModelLibraryModel.Instance().FoundationalModelLibrary_BasicInputOutput_StandardInputChannel);
        }
        public override string GetName()
        {
            return "StandardOutput";
        }

        public override void Open(Status errorStatus)
        {
            if (!IsOpen())
            {
                reader = new StreamReader(Console.OpenStandardInput());
            }
        }

        public override void Close(Status errorStatus)
        {
            if (IsOpen())
            {
                try
                {
                    reader?.Close();
                }
                catch (IOException)
                {
                }
            }
            reader = null;
        }

        public override bool IsOpen()
        {
            return reader is not null;
        }

        public override bool HasMore()
        {
            if (IsOpen())
            {
                try
                {
                    reader?.BaseStream.Seek(2, SeekOrigin.Current);
                    bool hasMore = reader?.Read() > 0;
                    reader?.BaseStream.Seek(-1, SeekOrigin.Current);
                }
                catch (IOException)
                {
                }
            }

            return HasMore();
        }

        public override Value Read(Status errorStatus)
        {
            StringValue? v = null;
            string s = ReadCharacter(errorStatus);
            if (s != null)
            {
                v = new StringValue
                {
                    value = s,
                    type = locus?.factory?.GetBuiltInType("String")
                };
            }
            return v!;
        }

        public override Value Peek(Status errorStatus)
        {
            StringValue? v = null;
            string s = PeekCharacter(errorStatus);
            if (s != null)
            {
                v = new StringValue
                {
                    value = s,
                    type = locus?.factory?.GetBuiltInType("String")
                };
            }
            return v!;
        }

        public override string ReadCharacter(Status errorStatus)
        {
            if (IsOpen())
            {
                try
                {
                    int c = reader!.Read();
                    if (c == -1)
                    {
                        errorStatus.SetStatus("StandardInputChannel", -2, "No input");
                        return null!;
                    }
                    else
                    {
                        return ((char)c).ToString();
                    }
                }
                catch (IOException e)
                {
                    errorStatus.SetStatus("StandardInputChannel", -100, e.Message);
                    return null!;
                }
            }
            else
            {
                errorStatus.SetStatus("StandardInputChannel", -1, "Not open");
                return null!;
            }
        }

        public override string PeekCharacter(Status errorStatus)
        {
            if (IsOpen())
            {
                try
                {
                    reader?.BaseStream.Seek(2, SeekOrigin.Current);
                    string s = ReadCharacter(errorStatus);
                    if (s != null)
                    {
                        reader?.BaseStream.Seek(-1, SeekOrigin.Current);
                    }
                    return s!;
                }
                catch (IOException e)
                {
                    errorStatus.SetStatus("StandardInputChannel", -100, e.Message);
                    return null!;
                }
            }
            else
            {
                errorStatus.SetStatus("StandardInputChannel", -1, "Not open");
                return null!;
            }
        }

        public override string ReadLine(Status errorStatus)
        {
            if (IsOpen())
            {
                if (HasMore())
                {
                    try
                    {
                        string? result = reader?.ReadLine();
                        return result!;
                    }
                    catch (IOException e)
                    {
                        errorStatus.SetStatus("StandardInputChannel", -100, e.Message);
                        return null!;
                    }
                }
                else
                {
                    errorStatus.SetStatus("StandardInputChannel", -2, "No input");
                    return null!;
                }
            }
            else
            {
                errorStatus.SetStatus("StandardInputChannel", -1, "Not open");
                return null!;
            }
        }

        public override bool? ReadBoolean(Status errorStatus)
        {
            if (!IsOpen())
            {
                errorStatus.SetStatus("StandardInputChannel", -1, "Not open");
                return null;
            }
            else
            {
                char[] cbuf = new char[4];
                try
                {
                    reader?.BaseStream.Seek(5, SeekOrigin.Current);
                }
                catch (IOException e)
                {
                    errorStatus.SetStatus("StandardInputChannel", -100, e.Message);
                    return null;
                }
                try
                {
                    int? n = reader?.Read(cbuf, 0, 4);
                    if (n < 4)
                    {
                        errorStatus.SetStatus("StandardInputChannel", -3, "Cannot convert");
                        reader?.BaseStream.Seek(-1, SeekOrigin.Current);
                        return null;
                    }
                    else
                    {
                        string s = new(cbuf);
                        if (s.Equals("true"))
                        {
                            return true;
                        }
                        else if (s.Equals("fals"))
                        {
                            n = reader?.Read();
                            if (n > 0 && ((char)n) == 'e')
                            {
                                return null;
                            }
                            else
                            {
                                errorStatus.SetStatus("StandardInputChannel", -3, "Cannot convert");
                                reader?.BaseStream.Seek(-1, SeekOrigin.Current);
                                return null;
                            }
                        }
                        else
                        {
                            errorStatus.SetStatus("StandardInputChannel", -3, "Cannot convert");
                            reader?.BaseStream.Seek(-1, SeekOrigin.Current);
                            return null;
                        }
                    }
                }
                catch (IOException e)
                {
                    errorStatus.SetStatus("StandardInputChannel", -100, e.Message);
                    try
                    {
                        reader?.BaseStream.Seek(-1, SeekOrigin.Current);
                    }
                    catch (IOException)
                    {
                    }
                    return null;
                }
            }
        }

        public override int? ReadInteger(Status errorStatus)
        {
            if (!IsOpen())
            {
                errorStatus.SetStatus("StandardInputChannel", -1, "Not open");
                return null;
            }
            else
            {
                try
                {
                    bool negate = false;
                    reader?.BaseStream.Seek(2, SeekOrigin.Current);
                    int c = reader!.Read();

                    if (c == '+' || c == '-')
                    {
                        negate = ((char)c) == '-';
                        reader.BaseStream.Seek(1, SeekOrigin.Current);
                        c = reader.Read();
                    }

                    int? n = ReadNatural(c, errorStatus);
                    if (n == null || !negate)
                    {
                        return n;
                    }
                    else
                    {
                        return -n;
                    }

                }
                catch (IOException e)
                {
                    errorStatus.SetStatus("StandardInputChannel", -100, e.Message);
                    return null;
                }
            }
        }

        public override float? ReadReal(Status errorStatus)
        {
            if (!IsOpen())
            {
                errorStatus.SetStatus("StandardInputChannel", -1, "Not open");
                return null;
            }
            else
            {
                try
                {
                    StringBuilder image = new();

                    reader?.BaseStream.Seek(2, SeekOrigin.Current);
                    int c = reader!.Read();
                    if (c == '+' || c == '-')
                    {
                        image.Append((char)c);
                        c = reader.Read();
                    }

                    bool? readDigits = ReadDigits(c, image);

                    if (readDigits is not null & readDigits! == false)
                    {
                        if (c < 0)
                        {
                            errorStatus.SetStatus("StandardInputChannel", -2, "No Input");
                        }
                        else
                        {
                            errorStatus.SetStatus("StandardInputChannel", -3, "Cannot convert");
                        }
                        reader.BaseStream.Seek(-1, SeekOrigin.Current);
                        return null;
                    }
                    else
                    {
                        reader.BaseStream.Seek(1, SeekOrigin.Current);
                        c = reader.Read();
                        if (c != '.')
                        {
                            reader.BaseStream.Seek(-1, SeekOrigin.Current);
                        }
                        else
                        {
                            image.Append('.');
                            reader.BaseStream.Seek(2, SeekOrigin.Current);
                            ReadDigits(reader.Read(), image);
                        }
                        reader.BaseStream.Seek(3, SeekOrigin.Current);
                        c = reader.Read();
                        if (c != 'E' && c != 'e')
                        {
                            reader.BaseStream.Seek(-1, SeekOrigin.Current);
                        }
                        else
                        {
                            image.Append('E');
                            c = reader.Read();
                            if (c == '+' || c == '-')
                            {
                                image.Append((char)c);
                                c = reader.Read();
                            }

                            readDigits = !ReadDigits(c, image);

                            if (readDigits is not null & readDigits! == false)
                            {
                                image.Append('0');
                            }
                        }
                        return float.Parse(image.ToString());
                    }

                }
                catch (IOException e)
                {
                    errorStatus.SetStatus("StandardInputChannel", -100, e.Message);
                    return null;
                }
            }
        }

        private bool? ReadDigits(int c, StringBuilder s)
        {
            if (c < '0' || c > '9')
            {
                reader?.BaseStream.Seek(-1, SeekOrigin.Current);
                return null;
            }
            else
            {
                s.Append((char)c);

                while (true)
                {

                    reader?.BaseStream.Seek(1, SeekOrigin.Current);
                    c = reader!.Read();

                    if (c >= '0' && c <= '9')
                    {
                        s.Append((char)c);
                    }
                    else
                    {
                        reader.BaseStream.Seek(-1, SeekOrigin.Current);
                        return true;
                    }
                }
            }
        }

        public override UnlimitedNatural ReadUnlimitedNatural(Status errorStatus)
        {
            UnlimitedNatural? u = null;

            if (!IsOpen())
            {
                errorStatus.SetStatus("StandardInputChannel", -1, "Not open");
            }
            else
            {
                try
                {
                    reader?.BaseStream.Seek(2, SeekOrigin.Current);
                    int c = reader!.Read();

                    if (c == '*')
                    {
                        u = new UnlimitedNatural
                        {
                            naturalValue = -1
                        };
                    }
                    else
                    {
                        int? n = ReadNatural(c, errorStatus);
                        if (n is not null)
                        {
                            u = new UnlimitedNatural
                            {
                                naturalValue = (int)n
                            };
                        }
                    }
                }
                catch (IOException e)
                {
                    errorStatus.SetStatus("StandardInputChannel", -100, e.Message);
                }
            }

            return u!;
        }

        private int? ReadNatural(int c, Status errorStatus)
        {
            try
            {
                if (c < 0)
                {
                    errorStatus.SetStatus("StandardInputChannel", -2, "No Input");
                    reader?.BaseStream.Seek(-1, SeekOrigin.Current);
                    return null;
                }
                else if (c < '0' || c > '9')
                {
                    errorStatus.SetStatus("StandardInputChannel", -3, "Cannot convert");
                    reader?.BaseStream.Seek(-1, SeekOrigin.Current);
                    return null;
                }

                int n = c - '0';

                while (true)
                {
                    reader?.BaseStream.Seek(1, SeekOrigin.Current);
                    c = reader!.Read();

                    if (c >= '0' && c <= '9')
                    {
                        n = n * 10 + c - '0';
                    }
                    else
                    {
                        reader?.BaseStream.Seek(-1, SeekOrigin.Current);
                        return n;
                    }
                }
            }
            catch (IOException e)
            {
                errorStatus.SetStatus("StandardInputChannel", -100, e.Message);
                return null;
            }
        }

        protected override Value New_()
        {
            return new StandardInputChannelObject();
        }
    } // StandardInputChannelObject
}
