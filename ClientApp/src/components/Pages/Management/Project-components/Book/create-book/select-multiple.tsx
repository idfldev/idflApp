import { useEffect, useState } from "react";
import { MultiSelect } from "react-multi-select-component";

interface AuditorInferface {
  label: string,
  value: string,
  key?: string;
  disabled?: boolean;
}
interface SelectMultipleProps {
  auditors: any[]; // Define the type of auditors prop
  onDataSelect: (selectedData: AuditorInferface[]) => void; // Callback function to return selected data
}
const SelectMultiple = ({ auditors, onDataSelect }: SelectMultipleProps) => {
  const [selected, setSelected] = useState<AuditorInferface[]>([]);
  const [data, setData] = useState<AuditorInferface[]>([]);

  const convert = () => {
    return auditors.map((item: any) => ({
      label: item.name,
      value: item.id
    }));
  };

  useEffect(() => {
    const convertedData = convert();
    setData(convertedData);
  }, [auditors]);

  useEffect(() => {
    onDataSelect(selected); // Invoke the callback function with selected data
  }, [selected, onDataSelect]);

  return (
    <div className="col-span-12">
      <MultiSelect
        options={data}
        value={selected}
        onChange={setSelected}
        labelledBy="Select"
      />
    </div>
  );
};

export default SelectMultiple;
