#define RC2
#undef DEBUG
using System;
using System.Collections;
using System.IO;
using Server;
using Server.Items;
using Server.Gumps;
using Server.Commands;
using System.Collections.Generic;
using Server.ContextMenus;
using Server.Network;
using Server.Targeting;

namespace Arya.Misc
{
    public class MultiGenerator
    {
        private static string m_CustomOutputDirectory = null;

        #region Template

        private const string m_SimpleCode = @"";

        private const string m_ComplexCode = @"";

        private const string m_ComplexNameCode = @"";

        private const string m_Template = @"{simplelist}";

        #endregion

        public static void Initialize()
        {
            CommandSystem.Register(
                "MultiGen",
                AccessLevel.Administrator,
                new CommandEventHandler(OnMultiGen)
            );
        }

        #region Command
        [
            Usage("MultiGen [<name> [namespace]]"),
            Description(
                "Brings up the addon script generator gump. When used with the name (and eventually namespace) parameter generates an addon script from the targeted region."
            )
        ]
        private static void OnMultiGen(CommandEventArgs e)
        {
            object[] state = new object[18];

            state[0] = "";
            state[1] = "Server.Items";
            state[2] = true;
            state[3] = false;
            state[4] = false;
            state[5] = true;
            state[6] = true;
            state[7] = true;
            state[8] = true;
            state[9] = -128;
            state[10] = 127;
            state[11] = state[13] = state[15] = 2;
            state[12] = state[14] = state[16] = 36653;

            if (e.Arguments.Length > 0)
            {
                state[0] = e.Arguments[0];

                if (e.Arguments.Length > 1)
                    state[1] = e.Arguments[1];
            }
            e.Mobile.SendGump(new InternalGump(e.Mobile, state));
        }
        #endregion

        private static void PickerCallback(
            Mobile from,
            Map map,
            Point3D start,
            Point3D end,
            object state
        )
        {
            object[] args = state as object[];
            int m_SimpleComponents = 0;
            int m_ComplexComponents = 0;
            int m_NamedComponents = 0;
            int m_TotalComponents = 0;

            if (start.X > end.X)
            {
                int x = start.X;
                start.X = end.X;
                end.X = x;
            }

            if (start.Y > end.Y)
            {
                int y = start.Y;
                start.Y = end.Y;
                end.Y = y;
            }

            Rectangle2D bounds = new Rectangle2D(start, end);

            string name = args[0] as string;
            string ns = args[1] as string;

            bool getStatics = (bool)args[2];
            bool getItems = (bool)args[3];
            bool getTiles = (bool)args[4];
            bool includeStaticRange = (bool)args[5];
            bool includeItemRange = (bool)args[6];
            bool includeTileRange = (bool)args[7];
            bool includeZRange = (bool)args[8];
            bool generateTest = (bool)args[17];

            sbyte min = sbyte.MinValue;
            sbyte max = sbyte.MaxValue;

            int minStaticID = 2;
            int maxStaticID = 36653;
            int minItemID = 2;
            int maxItemID = 36653;
            int minTileID = 2;
            int maxTileID = 36653;

            try
            {
                min = sbyte.Parse(args[9] as string);
            }
            catch { }
            try
            {
                max = sbyte.Parse(args[10] as string);
            }
            catch { }
            try
            {
                minStaticID = int.Parse(args[11] as string);
            }
            catch { }
            try
            {
                maxStaticID = int.Parse(args[12] as string);
            }
            catch { }
            try
            {
                minItemID = int.Parse(args[13] as string);
            }
            catch { }
            try
            {
                maxItemID = int.Parse(args[14] as string);
            }
            catch { }
            try
            {
                minTileID = int.Parse(args[15] as string);
            }
            catch { }
            try
            {
                maxTileID = int.Parse(args[16] as string);
            }
            catch { }

            Hashtable tiles = new Hashtable();

            if (getTiles)
            {
                for (int x = start.X; x <= end.X; x++)
                {
                    for (int y = start.Y; y <= end.Y; y++)
                    {
#if RC2
                        StaticTile[] stlist = map.Tiles.GetStaticTiles(x, y, true);
                        List<Server.StaticTile> list = new List<Server.StaticTile>();
                        List<Server.StaticTile> remove = new List<Server.StaticTile>();
#else
                        ArrayList list = map.GetTilesAt(new Point2D(x, y), false, false, true);
                        ArrayList remove = new ArrayList();
#endif

                        foreach (StaticTile t in stlist)
                        {
                            list.Add(t);

                            int id = t.ID - 36653;
                            if (id < 2 || id > 36653)
                                remove.Add(t);
                            else if (includeZRange && (t.Z < min || t.Z > max))
                                remove.Add(t);
                            else if (!includeZRange && (t.Z >= min && t.Z <= max))
                                remove.Add(t);
                            else if (includeTileRange && (id < minTileID || id > maxTileID))
                                remove.Add(t);
                            else if (!includeTileRange && (id >= minTileID && id <= maxTileID))
                                remove.Add(t);
                        }

                        foreach (StaticTile t in remove)
                        {
                            list.Remove(t);
                        }

                        if (list != null && list.Count > 0)
                        {
                            tiles[new Point2D(x, y)] = list;
                        }
                    }
                }
            }

            IPooledEnumerable en = map.GetItemsInBounds(bounds);
            ArrayList target = new ArrayList();
            bool fail = false;

            try
            {
                foreach (object o in en)
                {
                    if (getStatics)
                    {
                        Static s = o as Static;
                        if (s == null) { }
                        else if (s.Deleted) { }
                        else if (includeZRange && (s.Z < min || s.Z > max))
                            continue;
                        else if (!includeZRange && (s.Z >= min && s.Z <= max))
                            continue;
                        else if (
                            includeStaticRange && (s.ItemID < minStaticID || s.ItemID > maxStaticID)
                        )
                            continue;
                        else if (
                            !includeStaticRange
                            && (s.ItemID >= minStaticID && s.ItemID <= maxStaticID)
                        )
                            continue;
                        else
                        {
                            target.Add(o);
#if DEBUG
                            Console.WriteLine("Static={0}:{1}", s.GetType().ToString(), s.ItemID);
#endif
                            continue;
                        }
                    }
                    if (getItems)
                    {
                        Static s = o as Static;
                        if (s != null) // Don't want a static
                            continue;
                        Item i = o as Item;
                        if (i == null)
                            continue;
                        else if (i.Deleted)
                            continue;
                        else if (i.ItemID < 2 || i.ItemID > 36653) // This is not an Item within the normal artwork.. multi... etc.. Toss it
                            continue;
                        else if (includeZRange && (i.Z < min || i.Z > max))
                            continue;
                        else if (!includeZRange && (i.Z >= min && i.Z <= max))
                            continue;
                        else if (includeItemRange && (i.ItemID < minItemID || i.ItemID > maxItemID))
                            continue;
                        else if (
                            !includeItemRange && (i.ItemID >= minItemID && i.ItemID <= maxItemID)
                        )
                            continue;
#if DEBUG
                        Console.WriteLine("item={0}:{1}, {2}-map{3}", i.GetType().ToString(), i.ItemID, i.Deleted, i.Map);
#endif
                        target.Add(o);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                from.SendMessage(0x40, "The targeted components have been modified. Please retry.");
                fail = true;
            }
            finally
            {
                en.Free();
            }

            if (fail)
                return;

            if (target.Count == 0 && tiles.Keys.Count == 0)
            {
                from.SendMessage(0x40, "No components have been selected.");
                from.SendGump(new InternalGump(from, args));
                return;
            }

            // Get center
            Point3D center = new Point3D();
            center.Z = 127;

            int x1 = bounds.End.X;
            int y1 = bounds.End.Y;
            int x2 = bounds.Start.X;
            int y2 = bounds.Start.Y;

            // Get correct bounds
            foreach (Item item in target)
            {
                if (item.Z < center.Z)
                {
                    center.Z = item.Z;
                }

                x1 = Math.Min(x1, item.X);
                y1 = Math.Min(y1, item.Y);
                x2 = Math.Max(x2, item.X);
                y2 = Math.Max(y2, item.Y);
            }
            MultiIdentifyAddon IdentifyAddon = null;

            if (generateTest)
                IdentifyAddon = new MultiIdentifyAddon("init");

            foreach (Point2D p in tiles.Keys)
            {
#if RC2
                List<Server.StaticTile> list = tiles[p] as List<Server.StaticTile>;
#else
                ArrayList list = tiles[p] as ArrayList;
#endif

                if (list == null)
                {
                    Console.WriteLine("The list is null... ");
                    return;
                }

                foreach (StaticTile t in list)
                {
                    if (t.Z < center.Z)
                    {
                        center.Z = t.Z;
                    }
                }

                x1 = Math.Min(x1, p.X);
                y1 = Math.Min(y1, p.Y);
                x2 = Math.Max(x2, p.X);
                y2 = Math.Max(y2, p.Y);
            }

            center.X = x1 + ((x2 - x1) / 2);
            center.Y = y1 + ((y2 - y1) / 2);

            // Build items
            System.Text.StringBuilder nc = new System.Text.StringBuilder();
            nc.Append("");
            System.Text.StringBuilder sl = new System.Text.StringBuilder();
            sl.Append("");
            System.Text.StringBuilder cl = new System.Text.StringBuilder();
            cl.Append("");
            System.Text.StringBuilder sc = new System.Text.StringBuilder();
            sc.Append("");
            System.Text.StringBuilder cc = new System.Text.StringBuilder();
            cc.Append("");

            int simplecount = 0;
            // Tiles
            foreach (Point2D p in tiles.Keys)
            {
#if RC2
                List<Server.StaticTile> list = tiles[p] as List<Server.StaticTile>;
#else
                ArrayList list = tiles[p] as ArrayList;
#endif
                int xOffset = p.X - center.X;
                int yOffset = p.Y - center.Y;

                foreach (StaticTile t in list)
                {
                    int zOffset = t.Z - center.Z;
                    int id = t.ID - 36653;
                    m_SimpleComponents++;
                    simplecount++;
                    m_TotalComponents++;
                    if (simplecount > 1)
                        sl.Append("---");
                    sl.Append("!!!");
                    sl.AppendFormat("{0}, {1}, {2}, {3}", id, xOffset, yOffset, zOffset);
                    sl.Append("___");
                    if (generateTest)
                        AddIdentifyAddOnComponent(
                            IdentifyAddon,
                            id,
                            xOffset,
                            yOffset,
                            zOffset,
                            0,
                            -1,
                            string.Format(
                                "({0}):{1},{2},{3}",
                                m_TotalComponents,
                                xOffset,
                                yOffset,
                                zOffset
                            ),
                            0
                        );
                }
            }
            // Statics & Items
            foreach (Item item in target)
            {
                if (item.Deleted)
                    continue;
                int xOffset = item.X - center.X;
                int yOffset = item.Y - center.Y;
                int zOffset = item.Z - center.Z;
                string id = "0x" + (item.ItemID).ToString("X");

                m_SimpleComponents++;
                m_TotalComponents++;
                simplecount++;
                if (simplecount > 1)
                    sl.Append("");
                sl.Append("");
                sl.AppendFormat("{0} {1} {2} {3}", id, xOffset, yOffset, zOffset);

                if (
                    item.ItemID == 3026
                    || item.ItemID == 3025
                    || item.ItemID == 1711
                    || item.ItemID == 1709
                    || item.ItemID == 1701
                    || item.ItemID == 1703
                    || item.ItemID == 1663
                    || item.ItemID == 1661
                    || item.ItemID == 1653
                    || item.ItemID == 1655
                )
                {
                    sl.Append(" 0 0\n");
                }
                else
                {
                    sl.Append(" 1 0\n");
                }

                if (generateTest)
                    AddIdentifyAddOnComponent(
                        IdentifyAddon,
                        item.ItemID,
                        xOffset,
                        yOffset,
                        zOffset,
                        item.Hue,
                        -1,
                        string.Format(
                            "({0},{1}): {2}, {3}, {4}",
                            m_TotalComponents,
                            item.ItemID,
                            xOffset,
                            yOffset,
                            zOffset
                        ),
                        0
                    );
            }
            if (cc.Length > 4)
                cl.AppendFormat("{0}", cc.ToString());
            if (m_SimpleComponents > 0)
                sl.Append("");
            if (m_ComplexComponents > 0)
                cl.Append("");

            string output = m_Template.Replace("{name}", name);
            output = output.Replace("{simplelist}", m_SimpleComponents > 0 ? sl.ToString() : "");
            output = output.Replace(
                "{simplecomponentscode}",
                m_SimpleComponents > 0 ? m_SimpleCode : ""
            );
            output = output.Replace("{complexlist}", m_ComplexComponents > 0 ? cl.ToString() : "");
            output = output.Replace(
                "{complexcomponentscode}",
                m_ComplexComponents > 0 ? m_ComplexCode : ""
            );
            output = output.Replace(
                "{namedcomponentscode}",
                m_NamedComponents > 0 ? nc.ToString() : ""
            );
            output = output.Replace(
                "{complexnamecomponentscode}",
                (m_ComplexComponents > 0 || m_NamedComponents > 0) ? m_ComplexNameCode : ""
            );

            output = output.Replace("{namespace}", ns);

            StreamWriter writer = null;
            string path = null;

            if (m_CustomOutputDirectory != null)
                path = Path.Combine(
                    m_CustomOutputDirectory,
                    string.Format(@"TheMulti\{0}Multi.txt", name)
                );
            else
                path = Path.Combine(
                    Core.BaseDirectory,
                    string.Format(@"TheMulti\{0}Multi.txt", name)
                );

            fail = false;

            try
            {
                string folder = Path.GetDirectoryName(path);

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                writer = new StreamWriter(path, false);
                writer.Write(output);
            }
            catch
            {
                from.SendMessage(0x40, "An error occurred when writing the file.");
                fail = true;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }

            if (!fail)
            {
                from.SendMessage(0x40, "Script saved to {0}", path);
                from.SendMessage(0x40, "Total components in AddOn: {0}", m_TotalComponents);
                if (generateTest && IdentifyAddon != null)
                {
                    from.SendMessage(0x37, "Now target a land tile to place a your addon.");
                    from.Target = new InternalTarget(IdentifyAddon);
                }
            }
        }

        private static void AddIdentifyAddOnComponent(
            MultiIdentifyAddon ai,
            int item,
            int xoffset,
            int yoffset,
            int zoffset,
            int hue,
            int lightsource,
            string name,
            int amount
        )
        {
            if (ai == null)
                return;
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1) // Note: a warning will show on the console regarding a non-stackable item....
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType)lightsource;
            ai.AddComponent(ac, xoffset, yoffset, zoffset);
        }

        private class InternalTarget : Target
        {
            private MultiIdentifyAddon m_IdentifyAddon;

            public InternalTarget(MultiIdentifyAddon IdentifyAddon)
                : base(12, false, TargetFlags.None)
            {
                m_IdentifyAddon = IdentifyAddon;
                CheckLOS = true;
                AllowGround = true;
                DisallowMultis = true;
                Range = 15;
            }

            protected override void OnTargetCancel(Mobile from, TargetCancelType cancelType)
            {
                if (m_IdentifyAddon != null)
                    m_IdentifyAddon.Delete();
            }

            protected override void OnTarget(Mobile from, object o)
            {
                if (o != null)
                {
                    if (o is LandTarget)
                    {
                        LandTarget l = o as LandTarget;
                        m_IdentifyAddon.MoveToWorld(l.Location, from.Map);
                    }
                    else
                    {
                        from.SendMessage(37, "Use must target a land tile to place your addon.");
                        if (m_IdentifyAddon != null)
                            m_IdentifyAddon.Delete();
                    }
                }
            }
        }

        #region Gump
        private class InternalGump : Gump
        {
            private const int LabelHue = 0x480;
            private const int TitleHue = 0x35;
            private object[] m_State;

            public InternalGump(Mobile m, object[] state)
                : base(100, 50)
            {
                m.CloseGump(typeof(InternalGump));
                m_State = state;
                MakeGump();
            }

            private void MakeGump()
            {
                Closable = true;
                Disposable = true;
                Dragable = true;
                Resizable = false;
                AddPage(0);
                AddBackground(0, 0, 440, 260, 9260);
                //AddAlphaRegion(10, 10, 430, 260);  //uncomment this line if you like see-thru menus
                AddHtml(
                    0,
                    15,
                    440,
                    20,
                    Center(Color("CEO's Yet Another Arya Addon Generator(YAAAG)", 0x000080)),
                    false,
                    false
                );
                int x = 40;
                AddLabel(20, x, LabelHue, @"Name");
                AddImageTiled(95, x, 165, 18, 9274);
                AddTextEntry(95, x, 165, 20, LabelHue, 0, m_State[0] as string); // Name
                x += 20;
                AddLabel(20, x, LabelHue, @"Namespace");
                AddImageTiled(95, x, 165, 18, 9274);
                AddTextEntry(95, x, 165, 20, LabelHue, 1, m_State[1] as string); // Namespace
                AddLabel(340, x, TitleHue, @"ID Range");
                x += 20;
                AddLabel(20, x, TitleHue, @"Export");
                AddLabel(170, x, TitleHue, @"ID Range");
                AddLabel(320, x, TitleHue, @"Include/Exclude");
                x += 25;
                // Export Statics, Items, and Tiles
                string[] exportString = new string[] { "Statics", "Items", "Tiles" };
                for (int i = 0; i < 3; i++)
                {
                    DisplayExportLine(
                        x,
                        i,
                        ((bool)m_State[i + 2]),
                        ((bool)m_State[i + 5]),
                        exportString[i],
                        m_State[11 + (i * 2)].ToString(),
                        m_State[12 + (i * 2)].ToString()
                    );
                    x += (i < 2 ? 25 : 15);
                }
                AddImageTiled(15, x + 15, 420, 1, 9304);
                x += 25;
                // Z Range
                AddCheck(350, x, 9026, 9027, ((bool)m_State[8]), 6);
                AddLabel(20, x, LabelHue, @"Z Range");
                AddImageTiled(115, x + 15, 50, 1, 9274);
                AddTextEntry(115, x - 5, 50, 20, LabelHue, 2, m_State[9].ToString());
                AddLabel(185, x, LabelHue, @"to");
                AddImageTiled(225, x + 15, 50, 1, 9274);
                AddTextEntry(225, x - 5, 50, 20, LabelHue, 3, m_State[10].ToString());
                x += 25;

                // Buttons
                AddButton(20, x, 4020, 4021, 0, GumpButtonType.Reply, 0);
                AddLabel(55, x, LabelHue, @"Cancel");
                AddButton(155, x, 4005, 4006, 1, GumpButtonType.Reply, 0);
                AddLabel(195, x, LabelHue, @"Generate");
                AddButton(300, x, 4005, 4006, 2, GumpButtonType.Reply, 0);
                AddLabel(340, x, LabelHue, @"Test & Gen");
            }

            private void DisplayExportLine(
                int x,
                int index,
                bool state,
                bool include,
                string heading,
                string min,
                string max
            )
            {
                //AddCheck(20, x, 9026, 9027, state, index);
                AddCheck(20, x, 9026, 9027, true, index);
                AddLabel(40, x, LabelHue, heading);
                AddImageTiled(115, x + 15, 50, 1, 9274);
                AddTextEntry(115, x - 5, 50, 20, LabelHue, 4 + (index * 2), min); // Tile ID Min
                AddLabel(185, x, LabelHue, @"to");
                AddImageTiled(225, x + 15, 50, 1, 9274);
                AddTextEntry(225, x - 5, 50, 20, LabelHue, 5 + (index * 2), max); // Tile ID Max
                AddCheck(350, x, 9026, 9027, include, index + 3); // Include or Exclude compare?
            }

            private string Center(string text)
            {
                return String.Format("<CENTER>{0}</CENTER>", text);
            }

            private string Color(string text, int color)
            {
                return String.Format("<BASEFONT COLOR=#{0:X6}>{1}</COLOR>", color, text);
            }

            public override void OnResponse(Server.Network.NetState sender, RelayInfo info)
            {
                if (info.ButtonID == 0)
                    return;
                else if (info.ButtonID == 1)
                    m_State[17] = false;
                else
                    m_State[17] = true;

                foreach (TextRelay text in info.TextEntries)
                    m_State[text.EntryID < 2 ? text.EntryID : text.EntryID + 7] = text.Text;

                // Reset checks
                for (int x = 2; x <= 8; x++)
                    m_State[x] = false;

                foreach (int check in info.Switches)
                    m_State[check + 2] = true; // Offset by 2 in the state object

                if (Verify(sender.Mobile, m_State))
                {
                    BoundingBoxPicker.Begin(
                        sender.Mobile,
                        new BoundingBoxCallback(MultiGenerator.PickerCallback),
                        m_State
                    );
                }
                else
                {
                    sender.Mobile.SendMessage(
                        0x40,
                        "Please review the generation parameters, some are invalid."
                    );
                    sender.Mobile.SendGump(new InternalGump(sender.Mobile, m_State));
                }
            }

            private static bool Verify(Mobile from, object[] state)
            {
                if (state[0] == null || (state[0] as string).Length == 0)
                {
                    from.SendMessage(0x40, "Name field is invalid or missing.");
                    return false;
                }

                if (state[1] == null || (state[1] as string).Length == 0)
                {
                    from.SendMessage(0x40, "Namespace field is invalid or missing.");
                    return false;
                }

                if (!((bool)state[2] || (bool)state[3] || (bool)state[4]))
                {
                    from.SendMessage(
                        0x40,
                        "You must have least one Export button selected. (Static/Items/Tiles)"
                    );
                    return false;
                }

                string[] errors = new string[]
                {
                    "Z Range Min",
                    "Z Range Max",
                    "Static Min ID",
                    "Static Max ID",
                    "Item Min ID",
                    "Item Max ID",
                    "Tile Min ID",
                    "Tile Max ID"
                };

                for (int x = 0; x < 8; x++)
                    if (!CheckNumber(x < 2 ? 0 : 1, state[x + 9] as string, errors[x], from))
                        return false;
                return true;
            }

            private static bool CheckNumber(int numType, string number, string error, Mobile from)
            {
                sbyte sbyteTemp;
                int intTemp;
                try
                {
                    if (numType == 0)
                        sbyteTemp = sbyte.Parse(number);
                    else
                        intTemp = int.Parse(number);
                }
                catch
                {
                    from.SendMessage(0x40, "There's a problem with the {0} field.", error);
                    return false;
                }

                return true;
            }
        }
        #endregion
    }
}

#region MultiIdentifyAddon

namespace Server.Items
{
    public class MultiIdentifyAddon : BaseAddon
    {
        [Constructable]
        public MultiIdentifyAddon(string init)
        {
            // Nothing really here, just prevents adding a null contruct via [add command
        }

        [Constructable]
        public MultiIdentifyAddon()
        {
            this.Delete();
        }

        public MultiIdentifyAddon(Serial serial)
            : base(serial) { }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // Version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
            if (this.Map == null || this.Map == Map.Internal)
                this.Delete(); // Remove it because it's most
        }

        public void ReDeed(Mobile m)
        {
            this.Delete();
        }
    }
}
#endregion
