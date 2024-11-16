using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace EASSET.Helpers;

public static class clsGlobal
{
    public static DataTable getData(string strSQL, System.Data.SqlClient.SqlParameter[] paramArr = null)
    {
        DataTable dtData = new DataTable();

        //Serenity.Data.UnitOfWork uow = new UnitOfWork(;

        SqlConnection conn = new SqlConnection("Server=10.20.30.24;Database=EASSET;User Id=usersikekah;Password=N4tuna@#S!k3kah;Encrypt=false");

        try
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            using (SqlCommand cmd = new SqlCommand(strSQL))
            {
                cmd.Connection = conn;
                cmd.CommandText = strSQL;
                if (paramArr != null)
                {
                    cmd.Parameters.AddRange(paramArr);
                }
                cmd.CommandTimeout = 0;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dtData.Load(dr);
                    dr.Close();
                    dtData.TableName = "dtData";
                }
            }

        }
        catch (Exception ex)
        {
            //clsGlobal.generateErrMessageAndSendmail(ex, false);
        }
        finally
        {
            if (conn.State == ConnectionState.Open) conn.Close();
            conn = null;
        }
        return dtData;
    }

    public static string GetIPAddr()
    {

        String IPAddr = "";
        String HostName = System.Net.Dns.GetHostName().ToString();

        System.Net.IPHostEntry IPHostEntry = System.Net.Dns.GetHostEntry(HostName.ToString());
        System.Net.IPAddress[] IPAddress = IPHostEntry.AddressList;

        for (int i = 0; i <= IPAddress.Length - 1; i++)
        {
            IPAddr = IPAddress[i].ToString();
        }

        return IPAddr;
    }

    public static string GetHostIPAddr()
    {

        String HostName = System.Net.Dns.GetHostName().ToString();
        String IPAddr = GetIPAddr();
        String HostNameAddr = HostName + " (" + IPAddr + ")";

        return HostNameAddr;
    }

    public static String getData1Field(string strSQL)
    {
        DataTable dtData = new DataTable();
        string strData = "";

        //Serenity.Data.UnitOfWork uow = new UnitOfWork(;

        SqlConnection conn = new SqlConnection("Server=10.20.30.24;Database=EASSET;User Id=usersikekah;Password=N4tuna@#S!k3kah;Encrypt=false");

        try
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            using (SqlCommand cmd = new SqlCommand(strSQL))
            {
                cmd.Connection = conn;
                cmd.CommandText = strSQL;
                cmd.CommandTimeout = 0;
                using (System.Data.Common.DbDataReader dr = cmd.ExecuteReader())
                {
                    dtData.Load(dr);
                    dr.Close();
                    dtData.TableName = "dtData";
                }
            }

        }
        catch (Exception ex)
        {
            //clsGlobal.generateErrMessageAndSendmail(ex, false);
        }
        finally
        {
            if (conn.State == ConnectionState.Open) conn.Close();
            conn = null;
        }
        if (dtData.Rows.Count > 0) { strData = dtData.Rows[0][0] + ""; }
        return strData;
    }

    public static String getNewID()
    {
        string strResult = "";
        string strSql = @"select left(NEWID(),20) as NewID";
        strResult = getData1Field(strSql);
        return strResult;
    }

    public static DateTime getServerDate()
    {
        DataTable dtData = getData("select getDate()");
        DateTime dateNow = DateTime.MinValue;
        if (dtData.Rows.Count > 0)
        {
            dateNow = clsGlobal.GetParseDate(dtData.Rows[0][0]);
        }
        return dateNow;
    }
    public static string getServerYear()
    {
        DataTable dtData = getData("select YEAR(GETDATE())");
        string Year = "";
        if (dtData.Rows.Count > 0)
        {
             Year = Convert.ToString(dtData.Rows[0][0]);
        }
        return Year;
    }
    public static DateTime GetParseDate(object strDate)
    {
        DateTime m_Out;
        DateTime.TryParse(Convert.ToString(strDate), out m_Out);
        return m_Out;
    }

    public static string DataTableToJSON(DataTable table)
    {
        string JSONString = string.Empty;
        JSONString = JsonConvert.SerializeObject(table);
        return JSONString;
    }

    public static DataTable getNamaPenggunaBarang()
    {
        string strSql = "(\n\tselect a.pegawai_id, a.nama, a.nip, a.tgl_lahir, a.tmt_cpns, a.tmt_pns, a.pendidikan, a.j_kel, e.pangkat,\n\t                            c.kode+' - '+c.nama as unit_kerja_view, b.pegawai_unit_kerja_id, b.jabatan_id, d.nama_jabatan,\n\t                            e.gol2, f.jabatan_nama, c.unit_kerja_id, c.nama as unitnama, case when coalesce(d.eselon,0)=0 then 5 else d.eselon end as eselon,\n\t\t                            a.pegawai_id+'|'+c.unit_kerja_id as id, c.nama+'[br]<b>'+a.nama+'</b>' as text\n\t                            from INFIS_TPP_2020.dbo.m_pegawai a\n\t                            inner join INFIS_TPP_2020.dbo.t_pegawai_unit_kerja b on a.pegawai_id=b.pegawai_id and b.dlt='0' and b.status_aktif='1'\n\t                            inner join INFIS_TPP_2020.dbo.m_unit_kerja c on b.unit_kerja_id=c.unit_kerja_id and c.dlt='0'\n\t                            inner join INFIS_TPP_2020.dbo.m_jabatan d on b.jabatan_id=d.jabatan_id and d.dlt='0'\n\t                            left outer join \n\t                            (\n\t\t                            select a.pegawai_id, c.gol1, c.gol2, c.pangkat, b.tmt\n\t\t                            from\n\t\t                            (\n\t\t\t                            select a.pegawai_id, \n\t\t\t                            (\n\t\t\t\t                            select top 1 aa.pegawai_pangkat_id\n\t\t\t\t                            from INFIS_TPP_2020.dbo.m_pegawai_pangkat aa\n\t\t\t\t                            left join INFIS_TPP_2020.dbo.vws_getbulan bb on RIGHT('0'+convert(varchar,DATEPART(MM, aa.tmt)),2)=bb.bulanval\n\t\t\t\t                            where aa.pegawai_id=a.pegawai_id and aa.dlt='0' \n\t\t\t\t                            order by aa.tmt desc\n\t\t\t                            ) as pegawai_pangkat_id\n\t\t\t                            from INFIS_TPP_2020.dbo.m_pegawai a\n\t\t\t                            where a.dlt='0'\n\t\t                            ) a\n\t\t                            left join INFIS_TPP_2020.dbo.m_pegawai_pangkat b on a.pegawai_pangkat_id=b.pegawai_pangkat_id\n\t\t                            left join INFIS_TPP_2020.dbo.vws_pangkat_gol c on b.gol1=c.gol1\n\t                            ) e on a.pegawai_id=e.pegawai_id\n\t                            left join INFIS_TPP_2020.dbo.m_bank_jabatan f on d.bank_jabatan_id=f.bank_jabatan_id\n\t                            left join INFIS_TPP_2020.dbo.t_pegawai_plt g on a.pegawai_id=g.pegawai_id and g.dlt='0' and g.status_aktif='1'\n\t                            where a.dlt='0' and \n\t                            (\n\t\t                            d.nama_jabatan='Sekretaris Daerah' or d.nama_jabatan='Bupati Natuna' or d.nama_jabatan='Wakil Bupati Natuna'\n\t\t                            or (d.nama_jabatan like 'Asisten%' and d.eselon='2')\n\t\t                            or (d.nama_jabatan like 'Kepala%' and d.eselon='2')\n\t\t                            or (d.nama_jabatan like 'Inspektur%' and d.eselon='2')\n\t\t                            or (d.nama_jabatan like 'Camat%' and d.eselon='3')\n\t\t                            or (d.nama_jabatan like 'Direktur%' and d.eselon='3')\n\t\t                            or (d.nama_jabatan like 'Kepala Bagian%' and d.eselon='3')\n\t                            )\n                            )\n                            union all\n                            (\n\t                            select a.pegawai_id, a.nama, a.nip, a.tgl_lahir, a.tmt_cpns, a.tmt_pns, a.pendidikan, a.j_kel, e.pangkat,\n\t                            c.kode+' - '+c.nama as unit_kerja_view, b.pegawai_unit_kerja_id, h.jabatan_id, h.nama_jabatan,\n\t                            e.gol2, i.jabatan_nama, j.unit_kerja_id, j.nama as unitnama, case when coalesce(h.eselon,0)=0 then 5 else h.eselon end as eselon,\n\t                            a.pegawai_id+'|'+j.unit_kerja_id as id, j.nama+'[br]<b>'+a.nama+'</b>' as text\n\t                            from INFIS_TPP_2020.dbo.m_pegawai a\n\t                            inner join INFIS_TPP_2020.dbo.t_pegawai_unit_kerja b on a.pegawai_id=b.pegawai_id and b.dlt='0' and b.status_aktif='1'\n\t                            inner join INFIS_TPP_2020.dbo.m_unit_kerja c on b.unit_kerja_id=c.unit_kerja_id and c.dlt='0'\n\t                            left join INFIS_TPP_2020.dbo.m_jabatan d on b.jabatan_id=d.jabatan_id and d.dlt='0'\n\t                            left join \n\t                            (\n\t\t                            select a.pegawai_id, c.gol1, c.gol2, c.pangkat, b.tmt\n\t\t                            from\n\t\t                            (\n\t\t\t                            select a.pegawai_id, \n\t\t\t                            (\n\t\t\t\t                            select top 1 aa.pegawai_pangkat_id\n\t\t\t\t                            from INFIS_TPP_2020.dbo.m_pegawai_pangkat aa\n\t\t\t\t                            left join INFIS_TPP_2020.dbo.vws_getbulan bb on RIGHT('0'+convert(varchar,DATEPART(MM, aa.tmt)),2)=bb.bulanval\n\t\t\t\t                            where aa.pegawai_id=a.pegawai_id and aa.dlt='0' \n\t\t\t\t                            order by aa.tmt desc\n\t\t\t                            ) as pegawai_pangkat_id\n\t\t\t                            from INFIS_TPP_2020.dbo.m_pegawai a\n\t\t\t                            where a.dlt='0'\n\t\t                            ) a\n\t\t                            left join INFIS_TPP_2020.dbo.m_pegawai_pangkat b on a.pegawai_pangkat_id=b.pegawai_pangkat_id\n\t\t                            left join INFIS_TPP_2020.dbo.vws_pangkat_gol c on b.gol1=c.gol1\n\t                            ) e on a.pegawai_id=e.pegawai_id\n\t                            left join INFIS_TPP_2020.dbo.m_bank_jabatan f on d.bank_jabatan_id=f.bank_jabatan_id\n\t                            inner join INFIS_TPP_2020.dbo.t_pegawai_plt g on a.pegawai_id=g.pegawai_id and g.dlt='0' and g.status_aktif='1'\n\t                            inner join INFIS_TPP_2020.dbo.m_jabatan h on g.jabatan_id=h.jabatan_id and h.dlt='0'\n\t                            left join INFIS_TPP_2020.dbo.m_bank_jabatan i on h.bank_jabatan_id=i.bank_jabatan_id\n\t                            inner join INFIS_TPP_2020.dbo.m_unit_kerja j on g.unit_kerja_id=j.unit_kerja_id and j.dlt='0'\n\t                            where a.dlt='0' and \n\t                            (\n\t\t                            h.nama_jabatan='Sekretaris Daerah' or h.nama_jabatan='Bupati Natuna' or h.nama_jabatan='Wakil Bupati Natuna'\n\t\t                            or (h.nama_jabatan like 'Asisten%' and h.eselon='2')\n\t\t                            or (h.nama_jabatan like 'Kepala%' and h.eselon='2')\n\t\t                            or (h.nama_jabatan like 'Inspektur%' and h.eselon='2')\n\t\t                            or (d.nama_jabatan like 'Camat%' and d.eselon='3')\n\t\t                            or (d.nama_jabatan like 'Direktur%' and d.eselon='3')\n\t\t                            or (d.nama_jabatan like 'Kepala Bagian%' and d.eselon='3')\n\t                            )\n                            )\n                            order by eselon, nama";
        DataTable dtNamaPenggunaBarang = clsGlobal.getData(strSql);

        return dtNamaPenggunaBarang;
    }
}
