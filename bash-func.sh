###############################################################################

print_header () {
    print_banner $1 "[1;34m"
}

print_banner () {
    echo -e "\033$2###############################################################################"
    echo -e "$1"
    echo -e "###############################################################################\033[0m"
}

get_package_install_cmd() {
    uname=$(uname);
    case "$uname" in
        (*Linux*) openCmd='xdg-open'; ;;
        (*Darwin*) openCmd='open'; ;;
    esac;
}