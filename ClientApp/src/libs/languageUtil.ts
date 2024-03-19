import { LanguageKeyRequest } from "../constants/common.constants";

export default class LanguageUtils {
  static loadCurrentLanguage(): string {
    return loadFromLocalStorage(LanguageKeyRequest, false) as string;
  }
  static save(value: string, path: any, reload: boolean = true) {
    saveLocalStorage(LanguageKeyRequest, value);
    window.location.href = window.location.origin + path;
  }
}
type LocalStoreType = string | null | object;
const loadFromLocalStorage = (name: string, parseObject: boolean = false): LocalStoreType => {
  if (typeof window === "undefined" || !window.localStorage) return null;

  const serialized = window.localStorage.getItem(`${name}`);
  try {
    if (!serialized) return null;

    if (parseObject) {
      return JSON.parse(serialized);
    }

    return serialized;
  } catch (error) {
    // handle exception during parse data
    return null;
  }
};
const saveLocalStorage = (name: string, value: LocalStoreType) => {
  if (typeof window === "undefined" || !window.localStorage) return null;
  try {
    if (typeof value === "string") {
      window.localStorage.setItem(`${name}`, value);
    } else {
      window.localStorage.setItem(`${name}`, JSON.stringify(value));
    }
  } catch (error) {
    console.error(error);
  }
};