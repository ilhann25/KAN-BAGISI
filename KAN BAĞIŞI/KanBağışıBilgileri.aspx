<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="KanBağışıBilgileri.aspx.cs" Inherits="KAN_BAĞIŞI.KanBağışıBilgileri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
    <div class="row">
    <div class="col-md-6">
      <h2>Kullanıcı Bilgileri</h2>
      <form>
        <div class="form-group">
          <label for="fullname">Ad/Soyad:</label>
          <input type="text" class="form-control" id="fullname">
        </div>
        <div class="form-group">
          <label for="contact">İletişim Bilgileri:</label>
          <input type="text" class="form-control" id="contact" placeholder="İletişim numaranızı giriniz">
        </div>
        <div class="form-group">
          <label for="hospital">Hastane Adı:</label>
          <select class="form-control" id="hospital">
            <option>Bartın Devlet Hastanesi</option>
            <option>Bartın Ulus Devlet Hastanesi</option>
            <option>Özel Aktıp Merkezi</option>
            <option>Bartın Kadın Doğum ve Çocuk Hastalıkları</option>
            <option>Bartın Göğüs Hastalıkları Hastanesi</option>
          </select>
        </div>
        <div class="form-group">
          <label for="message">Mesaj:</label>
          <textarea class="form-control" rows="5" id="message"></textarea>
        </div>
        <div class="form-group">
          <label for="blood-type">Kan Grubu:</label>
          <select class="form-control" id="blood-type">
            <option>A Rh(+)</option>
            <option>B Rh(+)</option>
            <option>AB Rh(+)</option>
            <option>O Rh(+)</option>
            <option>A Rh(-)</option>
            <option>B Rh(-)</option>
            <option>AB Rh(-)</option>
            <option>O Rh(-)</option>
          </select>
        </div>
               <div class="form-group">
          <label for="gender">Cinsiyet:</label>
          <select class="form-control" id="gender">
            <option>Erkek</option>
            <option>Kadın</option>
            <option>Diğer</option>
          </select>
        </div>
        <button type="submit" class="btn btn-primary">Yayınlayınız</button>
      </form>
    </div>
  </div>

</asp:Content>








