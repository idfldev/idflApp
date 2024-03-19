import React, { useState } from "react";

// Props lesson: {items: [], heading: string }
interface LinksProps {
  items: string[];
  // onSelectItem : onClick event
  onSelectItem: (item: string) => void;
}

function NavbarLinks({ items, onSelectItem }: LinksProps) {
  // Hook
  const [selectedIndex, setSelectedIndex] = useState(-1);

  return (
    <>
      {items.length === 0 && <p>No item found</p>}
      <ul className="list-group">
        {items.map((item, index) => (
          <li
            className={
              selectedIndex === index
                ? "list-group-item active"
                : "list-group-item"
            }
            key={item}
            onClick={() => {
              setSelectedIndex(index);
              onSelectItem(item);
            }}
          >
            {item}
          </li>
        ))}
      </ul>
    </>
  );
}

export default NavbarLinks;
