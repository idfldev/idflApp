import { useEffect, useState } from "react";
import { MultiSelect } from "react-multi-select-component";
const options = [
  { label: "Grapes 🍇", value: "grapes" },
  { label: "Mango 🥭", value: "mango" },
  { label: "Strawberry 🍓", value: "strawberry", disabled: true },
];
interface AuditorInferface {
  label: string,
  value: any,
  key?: string;
  disabled?: boolean;
}
export const SelectMultiple = (props: any) => {
  const [selected, setSelected] = useState([]);
  const [data, setData] = useState<AuditorInferface[]>([])
  const convert = () => {
    const convertValue = props.auditors.map((items: any) => ({
      label: items.name,
      value: items.id
    }))
    return convertValue
  }

  useEffect(() => {
    const convertedData = convert();
    setData(convertedData); // Cập nhật state data với dữ liệu chuyển đổi
  }, [props.auditors]);
  console.log(data)
  return (
    <>
      <div className="col-span-12">
        <h1>Select Fruits</h1>
        <pre>{JSON.stringify(selected)}</pre>
        <MultiSelect
          options={data}
          value={selected}
          onChange={setSelected}
          labelledBy="Select"
        />
      </div>
    </>
  );
};
