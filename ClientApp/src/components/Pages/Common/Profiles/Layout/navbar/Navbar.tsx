import React from "react";
import Header from "../header/Header";
import NavbarLinks from "../navbar/NavbarLinks";
import "./navbar.css";

// const items = [
//   "Customer Information",
//   "Transactions",
//   "Assign Management",
//   "Account Transfer",
// ];

// const handleSelectItem = (item: string) => {
//   console.log(item);
// };

const Navbar = () => {
  return (
    <>
      {/* <Header /> */}
      <div>
        <div className="navbar-header flex top-0 justify-end p-1">
          {/* ---- languages ----- */}
          <div className="relative inline-block text-center">
            <button className="inline-flex w-full justify-center gap-x-1.5 rounded-md bg-white px-3 py-2 text-sm font-semibold text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 hover:bg-gray-50" id="menu-button" aria-expanded="true" aria-haspopup="true">
              EN
            </button>
            <div className="" role="menu" aria-orientation="vertical" aria-labelledby="menu-button">
              <div className="py-1" role="none">
                <a href="#" className="" role="menuitem">VI</a>
              </div>
            </div>
          </div>
          {/* ---- Login ------- */}
          {/* <div>
            <a href="/" className="register">
              Logout
            </a>
          </div> */}
          
        </div>
      </div>

      <div id="main-section">
        <div className="side-bar">
          <ul>
            <li>a</li>
            <li>b</li>
            <li>c</li>
            <li>d</li>
            <li>e</li>
          </ul>
        </div>
        {/* ---- Main Content ----------- */}
        <div className="main-content">Main Content</div>
      </div>
      

      {/* <NavbarLinks items={items}
      onSelectItem={handleSelectItem} /> */}
    </>
  );
};

export default Navbar;
