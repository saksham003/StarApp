import React from "react";

const Footer = () => {
  return (
    <div className="fixed-bottom">
      <footer className="bg-light text-center text-white">
        <div
          className="text-center p-3"
          style={{ backgroundColor: "rgba(0, 0, 0, 0.2)" }}
        >
          © 2022 Copyright:
          <a className="ms-1 text-white" href="/">
            StarApp
          </a>
        </div>
      </footer>
    </div>
  );
};

export default Footer;
