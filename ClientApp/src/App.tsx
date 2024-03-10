import React from "react";
import "./custom.css";
import {  Route, Routes } from "react-router-dom";
import { LoginApp } from "components/Pages/Management/Login/login";
import { ManagementApp } from "components/Pages/Management";
import { AdminPageApp } from "components/Pages/Admin";
import { LandingPageApp } from "components/Pages/Common";

export const App: React.FC = () => {
  return (
    <>
      <Routes>
        <Route path="/management/*" element={<ManagementApp />} />
        <Route path="/admin/*" element={<AdminPageApp />} />
        <Route path="/" element={<LandingPageApp />} />
        <Route path="/login" element={<LoginApp />} />
      </Routes>
    </>
  );
};
